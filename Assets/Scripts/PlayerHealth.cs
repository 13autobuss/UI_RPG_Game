using UnityEngine;

public class PlayerHealth
{
    int startHealth = 100;
    int zombieHit = -10;
    
        public void GetHit()
     {
           int currentHealth = startHealth + zombieHit;
     }
    
}
