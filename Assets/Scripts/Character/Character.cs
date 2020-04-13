using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    private string job;
    private int health;
    private Vector2 position;
    private Vector2 direction;
    private string target;

    public void work();
    public void born();
    public void die();
    public void getters();
    public void setters();


}
