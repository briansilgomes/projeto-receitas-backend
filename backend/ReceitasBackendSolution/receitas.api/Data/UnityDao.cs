using receitas.entidades;

namespace receitas.api.Data
{
    public class UnityDao : IUnityDao
    {
        ReceitasDbContext receitasdb;
        public UnityDao(ReceitasDbContext db)
        {
            receitasdb = db;
        }

        public List<Unity> GetUnity()
        {
            return receitasdb.Unidade.ToList();
        }

        public Unity GetDetail(int id)
        {
            try
            {
                return receitasdb.Unidade.First<Unity>(unity => unity.Idunity == id);
            }
            catch (Exception ex)
            {
                return null;
            }
      
        }

        public Unity AddUnity(Unity unity)
        {
            receitasdb.Unidade.Add(unity);
            receitasdb.SaveChanges();

            return unity;
        }

        public Unity UpdateUnity(Unity unity)
        {
            var exiteUnidade = receitasdb.Unidade.Where(data => data.Idunity == unity.Idunity).FirstOrDefault<Unity>();

            if (exiteUnidade != null)
            {
                exiteUnidade.Nameunity = unity.Nameunity.Trim();
                exiteUnidade.Siglaunity = unity.Siglaunity.Trim();
                receitasdb.SaveChanges();
            }

            return unity;

        }

        public Unity ValidateUnity(Unity unity)
        {
          return receitasdb.Unidade.Where(data => data.Nameunity == unity.Nameunity).FirstOrDefault<Unity>();
        }

        public List<Unity> GetSearch(string search)
        {
            var resultado = (from unity in receitasdb.Unidade
                    where unity.Nameunity.Contains(search)
                    select unity).ToList();
            return resultado;
        }
    }
}
