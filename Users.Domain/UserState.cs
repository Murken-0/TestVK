﻿
namespace Users.Domain
{
	public class UserState
	{
		public enum Values
		{
			Active = 1,
			Blocked = 2
		}

		public int Id { get; set; }
		public string Code { get; set; }
		public string Description { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
