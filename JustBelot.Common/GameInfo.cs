﻿namespace JustBelot.Common
{
    /// <summary>
    /// Game manager wrapper
    /// </summary>
    public class GameInfo
    {
        private readonly GameManager gameManager;

        internal GameInfo(GameManager gameManager)
        {
            this.gameManager = gameManager;
        }

        public delegate void PlayerBidHandler(BidEventArgs e);

        public event PlayerBidHandler PlayerBid;

        public int SouthNorthScore
        {
            get
            {
                return this.gameManager.SouthNorthScore;
            }
        }

        public int EastWestScore
        {
            get
            {
                return this.gameManager.EastWestScore;
            }
        }

        public PlayerInfo this[PlayerPosition position]
        {
            get
            {
                return new PlayerInfo(this.gameManager[position]);
            }
        }

        public PlayerInfo this[int playerIndex]
        {
            get
            {
                return new PlayerInfo(this.gameManager[playerIndex]);
            }
        }

        public void InformForBid(BidEventArgs eventArgs)
        {
            this.PlayerBid(eventArgs);
        }
    }
}
