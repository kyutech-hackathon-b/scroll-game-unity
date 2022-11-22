using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when the player is spawned after dying.
    /// </summary>
    public class PlayerSpawn : Simulation.Event<PlayerSpawn>
    {
        PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        public override void Execute()
        {
            var player = model.player;
            player.collider2d.enabled = true;
            player.controlEnabled = false;
            if (player.audioSource && player.respawnAudio)
                player.audioSource.PlayOneShot(player.respawnAudio);
            player.Teleport(model.spawnPoint.transform.position);
            player.jumpState = PlayerController.JumpState.Grounded;
            player.animator.SetBool("dead", false);
            model.scroll.ReturnStart();
            model.scroll.scrollSpeed = 0f;
            model.virtualCamera.m_Follow = model.scroll.transform;
            model.virtualCamera.m_LookAt = model.scroll.transform;
            Simulation.Schedule<EnablePlayerInput>(2f);
            model.map1.PlayerDeath();
            model.map2.PlayerDeath();
            model.enemies.PlayerDeath();
            model.token.PlayerDeath();
            player.PlayerDeath();
        }
        
    }
}