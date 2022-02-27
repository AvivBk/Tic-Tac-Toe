namespace TicTac
{
    public class Player
    {
        private int m_WinsCounter;

        // $G$ CSS-999 (-3) variable name should be starting with r_PascaleCased
        private readonly ePlayerSign m_PlayerSign;
        public Player(ePlayerSign i_Sign)
        {
            m_WinsCounter = 0;
            m_PlayerSign = i_Sign;
        }
        public int Score
        {
            get { return m_WinsCounter; }
            set { m_WinsCounter= value; }
        }
        public ePlayerSign Sign 
        {
            get { return m_PlayerSign; }
        }

    }
}
