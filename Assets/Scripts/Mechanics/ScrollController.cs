using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Gameplay;
using static Platformer.Core.Simulation;
using Platformer.Model;
using Platformer.Core;

public class ScrollController : MonoBehaviour
{
    Vector2 _initialPosition;
    public float scrollSpeed = 0.017f;
    readonly PlatformerModel model = Simulation.GetModel<PlatformerModel>();
    // Start is called before the first frame update
    void Start()
    {
        _initialPosition = new Vector2(this.transform.position.x, this.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {   
        float playerX = model.player.transform.position.x;
        float playerY = model.player.transform.position.y;
        this.transform.position = new Vector2(this.transform.position.x+scrollSpeed, playerY);
        float dis = Mathf.Abs(playerX - this.transform.position.x);
        if(dis > 8 &&  model.player.health.IsAlive)
        {
            Debug.Log("距離 : " + dis);
            Schedule<PlayerDeath>();
        }
    }

    void Restart(){
        scrollSpeed = 0.017f;
    }

    public void ReturnStart()
    {
        this.transform.position = _initialPosition;
    }
}
