using System.ComponentModel.DataAnnotations;
namespace MyWebApp.Api.Models
{
    public class FinOps_Requests
    {
        

        [Key]
        public int FID  { get; set; }
	    public string ServiceNowRef { get; set; }
	    public string Requestor { get; set; }
	    public string ResourceType { get; set; }
	    public string Description { get; set; }
	    public string ProjectNumber { get; set; }
	    public string NPD{ get; set; }
	    public decimal AnnualCosts_Proposed { get; set; }
	    public string FinOpsReq_status { get; set; }
	    public string FinOps_Comments { get; set; }
	    public decimal FinOps_AnnualCosts { get; set; }
	    public DateTime CreatedDate { get; set; }
	    public DateTime ModifiedDate { get; set; }
    }
}