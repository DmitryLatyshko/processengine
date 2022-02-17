namespace DLatyshko.Core.Process;

#region Class: ProcessExecuteResult

/// <summary>
/// Implement result of execute process.
/// </summary>
public class ProcessExecuteResult
{

	#region Properties: Public

	/// <summary>
	/// Status of result.
	/// </summary>
	public bool Success { get; set; }

	/// <summary>
	/// Error.
	/// </summary>
	public ExecuteError? Error { get; set; }

	#endregion

}

#endregion

#region Class: ExecuteError

/// <summary>
/// Implement execute error.
/// </summary>
public class ExecuteError
{

	#region Properties: Public

	/// <summary>
	/// Message.
	/// </summary>
	public string Message { get; set; }

	#endregion

}

#endregion
