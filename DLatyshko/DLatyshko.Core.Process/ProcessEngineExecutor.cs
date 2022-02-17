namespace DLatyshko.Core.Process;

#region Class: ProcessEngine

/// <summary>
/// Class containing logic for execute process.
/// </summary>
public class ProcessEngineExecutor : IProcessEngineExecutor
{

	#region Methods: Private

	private ProcessExecuteResult CreateSuccessResult() =>
		new ProcessExecuteResult
		{
			Success = true,
		};

	#endregion

	#region Methods: Public

	/// <inheritdoc cref="IProcessEngineExecutor.Execute"/>
	public ProcessExecuteResult Execute()
	{
		return CreateSuccessResult();
	}

	#endregion

}

#endregion
