using TileShop.Domain.Entities;
using TileShop.Domain.Repositories;

namespace TileShop.Infrastructure.Repositories;

public class CharacteristicsRepository : BaseRepository<Characteristics>, ICharacteristicsRepository
{
    public CharacteristicsRepository(ApplicationDbContext context)
        :base(context)
    {
        
    }


}
