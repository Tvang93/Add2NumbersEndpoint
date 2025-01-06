using Microsoft.AspNetCore.Mvc;

namespace Add2Numbers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Add2Numbers : ControllerBase
    {
        public List<string> sumSentence = new();

        [HttpPost]
        [Route("AddTwoNumbers/{firstNum}/{secondNum}")]
        public List<string> AddTwoNumbers(int firstNum, int secondNum)
        {
            sumSentence.Add($"The sum of {firstNum} and {secondNum} is {firstNum + secondNum}.");
            return sumSentence;
        }
    }
}