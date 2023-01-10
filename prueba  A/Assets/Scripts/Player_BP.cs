using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_BP
 {
int health;
int power;
string name;

public Player_BP(int health, int power, string name){
    
this.health = health;
this.power =power;
this.name = name;

Debug.Log(health + power + name);
  }  
}
