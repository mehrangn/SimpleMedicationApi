using AutoMapper;
using NSubstitute;
using NUnit.Framework;
using SimpleMedication.Application.Contracts.Persistance;
using SimpleMedication.Application.Features.Medications.Commands.CreateMedication;
using SimpleMedication.Application.Features.Medications.Models;
using SimpleMedication.Domain.Entities;

namespace SimpleMedication.Tests
{
    [TestFixture]
    public class CreateMedicationCommandHandlerTests
    {
        private IMedicationRepo _repositoryMock;
        private IMapper _mapperMock;
        private CreateMedicationCommandHandler _handler;

        [SetUp]
        public void SetUp()
        {
            _repositoryMock = Substitute.For<IMedicationRepo>();
            _mapperMock = Substitute.For<IMapper>();
        }

        [Test]
        public async Task Handle_ShouldAddMedication()
        {
            var command = new CreateMedicationCommand
            {
                Name = "Test Medication",
                Quantity = 10,
            };
            var medicationDTO = new MedicationDTO { Name = command.Name, Quantity = command.Quantity };
            _mapperMock.Map<MedicationDTO>(Arg.Any<Medication>()).Returns(medicationDTO);

            var result = await _handler.Handle(command, CancellationToken.None);

            await _repositoryMock.Received(1).AddAsync(Arg.Any<Medication>());
            Assert.That(result, Is.InstanceOf<MedicationDTO>());
            Assert.Equals(medicationDTO.Name, result.Name);
            Assert.Equals(medicationDTO.Quantity, result.Quantity);
        }
    }
}
