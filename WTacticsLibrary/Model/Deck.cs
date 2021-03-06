﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WTacticsLibrary.Model
{
    public class Deck : Base
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Zip { get; set; }

        public string Txt { get; set; }

        public bool IsAvailable { get; set; }

        public bool IsEditable { get; set; }

        public List<DeckCard> DeckCards { get; set; }
        

        public Deck()
        {
            DeckCards = new List<DeckCard>();
        }

    }
}
