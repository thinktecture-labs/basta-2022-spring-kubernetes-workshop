using Microsoft.AspNetCore.Mvc;

namespace BASTA.Kubernetes.Controllers {
    
    [ApiController]
    [Route("healthz")]
    public class HealthController: ControllerBase
    {

        [HttpGet]
        [Route("readiness")]
        public IActionResult IsReady() 
        {
            return Ok(new { HostName = System.Net.Dns.GetHostName()});
        }

        [HttpGet]
        [Route("liveness")]
        public IActionResult IsAlive()
        {
                return Ok(new { HostName = System.Net.Dns.GetHostName()});
        }

    }
}
