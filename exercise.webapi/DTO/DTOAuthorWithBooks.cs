﻿namespace exercise.webapi.DTO
{
    public class DTOAuthorWithBooks
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<DTOBookWithoutAuthorWithPublisher> Books { get; set; } = new List<DTOBookWithoutAuthorWithPublisher>();
    }
}
