﻿using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SigmaApp.Models
{

    public class Conversation
    {
        [Key]
        public int ConversationID { get; set; }
        public string RecentMessage { get; set; }

        [NotMapped]
        public ObservableCollection<Message> Messages { get; set; }

        public User Recipient { get; set; }

        public Conversation()
        {
            Messages = new ObservableCollection<Message>();
        }
    }

}
