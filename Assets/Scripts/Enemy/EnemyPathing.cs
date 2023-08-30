using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    [SerializeField] private Transform _waypointA;
    [SerializeField] private Transform _waypointB;
    [SerializeField] private float _moveSpeed = 2.0f;

    private Transform _currentWaypoint;
    private Vector3 _startPosition;
    private Vector3 _endPosition;
    private float _time = 0.0f;

    private void Start()
    {
        _currentWaypoint = _waypointA;
    }

    private void FixedUpdate()
    {
        if (PauseManagement.Instance.IsPaused || LevelManagement.Instance.IsGameOver) {
            return;
        }

        _startPosition = transform.position;
        _endPosition = _currentWaypoint.position;

        _time += Time.fixedDeltaTime;

        // For better understanding we will call the variable transitionProgress
        float transitionProgress = CalculateSmoothStepInterpolationValue(_time, _moveSpeed);

        // Perform the smooth transition using the SmoothStep curve
        transform.position = Vector3.Lerp(_startPosition, _endPosition, transitionProgress);

        if (Vector3.Distance(transform.position, _currentWaypoint.position) < 0.1f) {
            if (_currentWaypoint == _waypointA) {
                _currentWaypoint = _waypointB;
            } else {
                _currentWaypoint = _waypointA;
            }

            // Reset time for smooth transition
            _time = 0.0f;
        }
    }

    private float CalculateSmoothStepInterpolationValue(float time, float moveSpeed)
    {
        // Calculate t using SmoothStep curve
        // We changed the formular for the first t calculation to use the variable moveSpeed instead of smoothDuration
        // which would have been float t = time / smoothDuration. 
        // It would have been shorter but less intuitive for someone like a level designer
        float t = time * (1 + moveSpeed) / 100;
        t = t * t * (3f - 2f * t);

        return t;
    }
}
