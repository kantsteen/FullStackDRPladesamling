using RESTDRPladesamling.Model;

namespace RESTDRPladesamling.Repo
{
    public class RecordRepo
    {
        private List<Record> _record = new List<Record>();

        private int _nextId = 0;

        public IEnumerable<Record> GetAll()
        {
            IEnumerable<Record> result = new List<Record>(_record);

            return result;
        }

    }
}
