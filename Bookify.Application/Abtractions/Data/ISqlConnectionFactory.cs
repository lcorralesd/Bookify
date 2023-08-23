using System.Data;

namespace Bookify.Application.Abtractions.Data;
public interface ISqlConnectionFactory
{
    IDbConnection CreateConnection();
}
