﻿using UnityEngine;

public class TankModel
{
    private TankController tankController;

    public float movementSpeed;
    public float rotationSpeed;
    public TankTypes tankTypes;
    public Material color;

    public TankModel(float _movement, float _rotation, TankTypes _tankType, Material _color)
    {
        movementSpeed = _movement;
        rotationSpeed = _rotation;
        tankTypes = _tankType;
        color = _color;
    }
    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}
