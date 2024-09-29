using System.ComponentModel.DataAnnotations.Schema;


namespace PracticaCalificada2.Models
{
    [Table("t_cuentas")]
    public class CuentaBancaria
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }  // Identificador único de la cuenta
        public string? NombreTitular { get; set; }  // Nombre del titular de la cuenta
        public string? TipoCuenta { get; set; }  // Tipo de cuenta (Ej: Ahorros, Corriente)
        public decimal SaldoInicial { get; set; }  // Saldo inicial de la cuenta
        public string? Email { get; set; }  // Correo electrónico del titular
    }
}