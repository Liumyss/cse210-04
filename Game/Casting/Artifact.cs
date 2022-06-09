namespace cse210_04.Game.Casting
{
    /// <summary>
    /// <para>An item of cultural or historical interest.</para>
    /// <para>
    /// The responsibility of an Artifact is to provide a message about itself.
    /// </para>
    /// </summary>
    public class Artifact : Actor
    {
        private string message = "";

        /// <summary>
        /// Constructs a new instance of an Artifact.
        /// </summary>
        public Artifact()
        {
        }

        public int type { get; set; }

        public int GetScore()
        {
            int score = 0;
            if (type == 0)
            {
                score = -1; 
            }
            else if (type == 1)
            {
                score = 1;
            }

            return score;
        }
    }
}