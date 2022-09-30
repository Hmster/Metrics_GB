using MetricsManager.Controllers;
using MetricsManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricsManagerTests
{
    public class AgentsControllerTests
    {
        private AgentsController _agentsController;
        private AgentPool _agentPool;

        public AgentsControllerTests()
        {
            _agentPool = AgentPool.Instance;
            _agentsController = new AgentsController(_agentPool);

        }

        [Theory]
        [InlineData(5)]
        [InlineData(15)]
        [InlineData(25)]
        public void RegisterAgentTest(int agentId)
        {
            AgentInfo agentInfo = new AgentInfo() { AgentId = agentId, Enable = true };
            var actionResult = _agentsController.RegisterAgent(agentInfo);
            Assert.IsAssignableFrom<IActionResult>(actionResult);
        }

        [Theory]
        [InlineData(5)]
        public void EnableByIdTest(int agentId)
        {
            AgentInfo agentInfo = new AgentInfo() { AgentId = agentId, Enable = false };
            var actionResult = _agentsController.EnableAgentById(agentId);
            Assert.IsAssignableFrom<IActionResult>(actionResult);
        }

        [Theory]
        [InlineData(5)]
        public void DisableByIdTest(int agentId)
        {
            AgentInfo agentInfo = new AgentInfo() { AgentId = agentId, Enable = true };
            var actionResult = _agentsController.DisableAgentById(agentId);
            Assert.IsAssignableFrom<IActionResult>(actionResult);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(15)]
        [InlineData(25)]
        public void GetAllAgentsTest(int agentId)
        {
            AgentInfo agentInfo = new AgentInfo() { AgentId = agentId, Enable = true };
            var actionResult = _agentsController.GetAllAgents();
            Assert.IsAssignableFrom<IActionResult>(actionResult);
        }
    }
}
