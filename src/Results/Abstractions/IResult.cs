namespace Results.Abstractions;

public interface IResult
{
	/// <summary>
	///     Gets or sets the status code.
	/// </summary>
	/// <value>
	///     The status code, or null if no status code has been set.
	/// </value>
	/// <remarks>
	///     This status code is versatile, having applicability as both an internal status marker within the application, or
	///     externally as an HTTP status code when interacting over HTTP protocols.
	/// </remarks>
	public int? StatusCode { get; set; }
	
	/// <summary>
	///     Gets a boolean value which represents the status of the operation.
	/// </summary>
	/// <value>
	///     <c>true</c> if the operation succeeded, otherwise <c>false</c>.
	/// </value>
	public bool IsSucceed { get; }
	
	/// <summary>
	///     Gets a value indicating whether the result is faulted.
	/// </summary>
	/// <value><c>true</c> if the result is faulted; otherwise, <c>false</c>.</value>
	public bool IsFaulted { get; }
	
	/// <summary>
	///     Gets the type of the result contained in the Result object.
	/// </summary>
	/// <returns>The type of the result.</returns>
	/// <remarks>
	///     The Result object represents the result of an operation that can either succeed or fail.
	///     This method retrieves the type of the result stored within the Result object.
	/// </remarks>
	public Type ResultType { get; }
	
	/// <summary>
	///     Gets the type of the result value contained in the Result object.
	/// </summary>
	/// <returns>The type of the result value.</returns>
	/// <remarks>
	///     The Result object represents the result of an operation that can either succeed or fail.
	///     This method retrieves the type of the value unwrapped from the Result object.
	/// </remarks>
	public Type ValueType { get; }
}