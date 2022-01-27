using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*count the number of times whenever the player bumps into an obstacle*/
public class Scorer : MonoBehaviour
{
    int hitsCount = 0; 

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Hit") 
        {         
            hitsCount++; 
            Debug.Log("You bumped into a thing " +hitsCount+ " times");
            
        }
       /*If the player already bumped into the same obstacle before, I won't count it anymore
        E.g: I have 4 obstacles: A,B,C and D. The name of player is Hannah. If Hannah bumps into A the first time,
        I'll count 1 times. Then If Hannah still bumps into A the second time, I'll calcute it as 1 times for A.*/
    }
}
