namespace todo_fullstack_c_.Models;

// defines a new class called ErrorViewModel. The below logic waits for an error to occur before it gets and exposes an ID, thus triggering the View model for an error 
public class ErrorViewModel
{
  // gets and sets a requestId, which is dynamic 
    public string? RequestId { get; set; }

// conditionally show the RequestId if it exists (i.e. if not null or empty)
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
