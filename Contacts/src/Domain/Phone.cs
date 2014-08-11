namespace Domain
{
    public class Phone
    {
        public virtual int Id { get; set; }
        public virtual Abonent Abonent { get; set; }
        public virtual string Value { get; set; }
        public virtual TypeInfo Info { get; set; }
    }
}
