using RESTDRPladesamling.Model;

namespace RESTDRPladesamling.Repo
{
    public class RecordRepo
    {
        private List<Record> _record = new List<Record>();

        private int _nextId = 0;


        // test repo
        // can delete after add method implemented
        public RecordRepo()
        {
            _record.Add(new Record
            {
                Id = 0,
                Title = "testrecord",
                Artist = "testartist",
                Duration = 1,
                PublictaionYear = 2000
            });
        }

        public IEnumerable<Record> GetAll()
        {
            IEnumerable<Record> result = new List<Record>(_record);
            return result;
        }

    }
}
