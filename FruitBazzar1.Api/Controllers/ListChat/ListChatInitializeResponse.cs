﻿using FruitBazzar1.Api.Functions.Message;

namespace FruitBazzar1.Api.Controllers.ListChat
{
    public class ListChatInitializeResponse
    {
        public User User { get; set; } = null!;
        public IEnumerable<User> UserFriends { get; set; } = null!;
        public IEnumerable<LastestMessage> LastestMessages { get; set; } = null!;
    }
}
