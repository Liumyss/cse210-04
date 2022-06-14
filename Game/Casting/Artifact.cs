namespace cse210_04.Game.Casting
{
    /// <summary>
    /// <para>An item of cultural or historical interest.</para>
    /// <para>
    /// The responsibility of an Artifact is to provide the score of the game.
    /// </para>
    /// </summary>
    public class Artifact : Actor
    {
        private int score = 0;

        /// <summary>
        /// Constructs a new instance of an Artifact.
        /// </summary>
        public Artifact()
        {
        }

        /// <summary>
        /// Get the score from the artifact touched by the user
        /// </summary>
        public int GetScore()
        {
            return score;
        }
        /// <summary>
        /// Set the score of the user
        /// </summary>
        public void SetScore(int score)
        {
            this.score = score;
        }
    }
}