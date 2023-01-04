using Grpc.Core;
using System.Text.Json;
using static GrpcDemo.MeterReadingService;

namespace GrpcDemo.Services
{
    public class MeterReadingService : MeterReadingServiceBase
    {
        private readonly ILogger<MeterReadingService> _logger;

        public MeterReadingService(ILogger<MeterReadingService> logger)
        {
            _logger = logger;
        }

        public async override Task<StatusMessage> AddReading(ReadingPacket request, ServerCallContext context)
        {
            if (request.Successful == ReadingStatus.Success)
            {
                foreach(var reading in request.Readings)
                {
                    _logger.LogInformation($"Process reading: {JsonSerializer.Serialize(reading)}");
                }

                return new StatusMessage
                {
                    Success = ReadingStatus.Success,
                    Message = "Successfully processed all readings"
                };
            }

            return new StatusMessage
            {
                Success = ReadingStatus.Failure,
                Message = "Cannot process the readings because of the failure status"
            };
        }
    }
}