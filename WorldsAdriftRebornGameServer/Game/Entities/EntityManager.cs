namespace WorldsAdriftRebornGameServer.Game.Entities
{
    internal class EntityManager
    {
        private static long nextEntityId = 1;

        public static long NextEntityId => ++nextEntityId;
    }
}
