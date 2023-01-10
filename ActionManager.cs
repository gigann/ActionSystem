namespace ActionSystem
{
    /// <summary>
    /// Manages actions.
    /// </summary>
    public class ActionManager
    {
        private static Queue<IAction> _actions = new Queue<IAction>();

        public void Order(IAction action)
        {
            _actions.Enqueue(action);
        }

        public void Process()
        {
            int numberOfActions = _actions.Count;

            for (int i  = 0; i < numberOfActions; i++)
            {
                _actions.Dequeue().Execute();
            }
        }
    }
}
