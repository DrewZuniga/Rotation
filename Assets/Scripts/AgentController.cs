﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController : MonoBehaviour
{

    public AgentMovement movement;
    public PlayerInput input;

    private void Start()
    {
    
        movement = GetComponent<AgentMovement>();
        input = GetComponent<PlayerInput>();
     
    }

    private void Update()
    {
        movement.HandleMovement(input.OnMovementInput);
        movement.HandleMovementDirection(input.OnMovementDirectionInput);
    }
}
