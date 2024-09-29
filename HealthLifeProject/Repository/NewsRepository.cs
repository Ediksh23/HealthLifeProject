using HealthLifeProject.Commons;
using HealthLifeProject.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HealthLifeProject.Repository
{
    public class NewsRepository
    {
        private readonly HealthLifeDBContext _healthLifeDBContext;

        public NewsRepository(HealthLifeDBContext healthLifeDBContext)
        {
            _healthLifeDBContext = healthLifeDBContext;
        }

        public bool AddNews(News news)
        {
            _healthLifeDBContext.Add(news);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }

        public bool DeleteNewsByID(int newsID)
        {
            News news = _healthLifeDBContext.News.Find(newsID);
            _healthLifeDBContext.News.Remove(news);
            return _healthLifeDBContext.SaveChanges() == 1 ? true : false;
        }
        public IEnumerable<News> GetAllNews()
        {
            return _healthLifeDBContext.News.OrderBy(o => o.Id).ToList();
        }
    }
}
