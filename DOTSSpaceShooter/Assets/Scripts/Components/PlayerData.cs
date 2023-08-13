using Unity.Entities;

namespace SpaceShooter.Components
{
    public struct PlayerData : IComponentData
    {
        public float Speed;
        public Entity Entity;
    }
}