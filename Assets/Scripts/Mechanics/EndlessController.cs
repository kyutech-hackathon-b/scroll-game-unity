using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Model;
using Platformer.Core;

public class EndlessController : MonoBehaviour
{
   public GameObject player;
   Vector2 _initialPosition; 
   Vector2 position;
   readonly PlatformerModel model = Simulation.GetModel<PlatformerModel>();

   void Start()
   {
        _initialPosition = this.transform.position;
        position = _initialPosition;
   }

   void Update()
   {
        Vector2 playerPosition = player.transform.position;
        float dis = playerPosition.x - position.x;
        if(dis > 220)
        {
            Vector2 newPosition = new Vector2(position.x + 315.2f, position.y);
            model.token.PlayerDeath();
            model.enemies.PlayerDeath();
            this.transform.position = newPosition;
            position = newPosition;
            
        }
   }

   public void PlayerDeath()
   {
        this.transform.position = _initialPosition;
   }
}
