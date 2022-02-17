namespace DLatyshko.Core.Process;

#region Interface: IProcessEngine

/// <summary>
/// Interface used to execute process
/// </summary>
public interface IProcessEngineExecutor
{

	#region Methods: Public

	/// <summary>
	/// Executes process.
	/// </summary>
	/// <returns>Result of execute process <see cref="ProcessExecuteResult"/>.</returns>
	ProcessExecuteResult Execute();

	#endregion

}

#endregion
