namespace FlightServicesWeb.Models;
public class ServicesUser : IdentityUser
{
    /// <summary>
    /// 
    /// </summary>
    [Required]
    public string? DisplayName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [StringLength(256)]
    public string? Statement { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [DataType(DataType.DateTime)]
    public DateTime BirthDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [StringLength(128)]
    public string? Address { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [StringLength(32)]
    [Required]
    public string? State { get; set; }


    [Required()]
    public string? City { get; set; }

    [Required]
    public string? ZipCode { get; set; }






}
