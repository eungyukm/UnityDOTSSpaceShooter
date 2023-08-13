using Unity.Entities;
using UnityEngine;
using SpaceShooter.Components;

namespace SpaceShooter.Authorings
{
    public class PlayerAuthoring : MonoBehaviour
    {
        public float speed;
    }
    public class PlayerBaker : Baker<PlayerAuthoring>
    {
        public override void Bake(PlayerAuthoring authoring)
        {
            var entity = GetEntity(TransformUsageFlags.None);
            AddComponent<PlayerData>(entity, new PlayerData
            {
                Speed = authoring.speed
            });
        }
    }
}