namespace chessAPI;
public sealed class connectionStrings
    {
        /// <summary>
        /// Cadena de conexión a base de datos relacional
        /// </summary>
        public string? relationalDBConn { get; set; } = "Server=localhost;Port=5432;Database=chessDB;User Id=postgres;Password=misDatos2023!;Pooling=true;MinPoolSize=3;MaxPoolSize=20;Max Auto Prepare=15;Enlist=false;Auto Prepare Min Usages=3";
    }