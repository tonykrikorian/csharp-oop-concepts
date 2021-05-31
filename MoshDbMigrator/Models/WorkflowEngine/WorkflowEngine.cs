using MoshDbMigrator.Models.WorkflowEngine.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshDbMigrator.Models.WorkflowEngine
{
    public class WorkflowEngine
    {
        private ILogger _logger;
        private IList<IActivity> _activities;

        public WorkflowEngine(ILogger logger)
        {
            if(logger==null) throw new InvalidOperationException("Los servicios no pueden ser null");
            _activities = new List<IActivity>();
            _logger = logger;
        }
        /// <summary>
        /// Ejecuta el workflow con la lista de actividades
        /// </summary>
        public void Run()
        {
            if(_activities.Count==0) throw new InvalidOperationException("Debe ingresar al menos una actividad ");
            foreach (var activity in _activities)
            {
                activity.Execute();
                _logger.LogInfo("Workflow ejecurado correctamente");
            }
        }
        /// <summary>
        /// Agrega una actividad la lista de actividades del Workflow
        /// </summary>
        /// <param name="activity"></param>
        public void SetActivities(IActivity activity) 
        {
            if (activity == null) throw new InvalidOperationException("La actividad no puede ser null");
            _activities.Add(activity);
        }
    }
}
