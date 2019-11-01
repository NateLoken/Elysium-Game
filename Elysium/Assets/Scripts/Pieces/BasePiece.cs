﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePiece
{
    private int currentHealth;
    private int maxHealth;
    private int strength;
    private int movement;
    private int range;
    private int cost;
    private int posX;
    private int posY;

    protected int Range { get => range; set => range = value; }
    protected int Cost { get => cost; set => cost = value; }
    protected int CurrentHealth { get => currentHealth; set => currentHealth = value; }
    protected int MaxHealth { get => maxHealth; set => maxHealth = value; }
    protected int Strength { get => strength; set => strength = value; }
    protected int Movement { get => movement; set => movement = value; }
    protected int PosX { get => posX; set => posX = value; }
    protected int PosY { get => posY; set => posY = value; }
    
}
