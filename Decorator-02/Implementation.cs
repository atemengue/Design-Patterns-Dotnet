
namespace Decorator
{
    /// <summary>
    /// Component as Interface
    /// </summary>
   public interface IMailService
    {
        bool sendMail(string Message);
    }

    /// <summary>
    /// Concrete Component 01
    /// </summary>
    public class CloudMailService : IMailService
    {
        public bool sendMail(string message)
        {
            Console.WriteLine($"Message \"{message}\" " + 
            $"sent via {nameof(CloudMailService)}. ");
            return true;
        }
    }

    /// <summary>
    /// Concrete Component 02
    /// </summary>
    public class OnPermiseMailService : IMailService
    {
        public bool sendMail(string message)
        {
            Console.WriteLine($"Message \"{message}\" " +
            $"sent via {nameof(OnPermiseMailService)}. ");
            return true;
        }
    }
    /// <summary>
    /// Decorator
    /// </summary>
    public abstract class MailServiceDecoratorBase : IMailService
    {
        private readonly IMailService _mailService;

        // constructor
        public MailServiceDecoratorBase(IMailService mailService)
        {
            _mailService = mailService;
        }
        public virtual bool sendMail(string message)
        {
            return _mailService.sendMail(message);
        }
    }

    public class StatisticsDecorator : MailServiceDecoratorBase
    {
        public StatisticsDecorator(IMailService mailService) : base(mailService) { }

        public override bool sendMail(string message)
        {
            {
                // Fake collecting statistics
                Console.WriteLine($"Collecting statistics in {nameof(StatisticsDecorator)}.");
                return base.sendMail(message);
            }
        }
    }

    public class MessageDatabaseDecorator : MailServiceDecoratorBase
    {
        /// <summary>
        /// A list of  sent messages
        /// </summary>
        public List<string> sentMessages { get; private set; } = new List<string>();

        public MessageDatabaseDecorator(IMailService mailService) : base(mailService) { }

        public override bool sendMail(string message)
        {
            if (base.sendMail(message)) {
                // store sent Message
                sentMessages.Add(message);
                return true;
            }
            return false;
        }
    }
}
