#error TechTalk.SpecFlow.Generator.Interfaces.TestGenerationError
#error TechTalk.SpecFlow
#error Server stack trace: 
#error    at BoDi.ObjectContainer.TypeRegistration.Resolve(ObjectContainer container, RegistrationKey keyToResolve, ResolutionList resolutionPath)
#error    at BoDi.ObjectContainer.ResolveObject(RegistrationKey keyToResolve, ResolutionList resolutionPath)
#error    at BoDi.ObjectContainer.Resolve(Type typeToResolve, ResolutionList resolutionPath, String name)
#error    at BoDi.ObjectContainer.Resolve[T](String name)
#error    at TechTalk.SpecFlow.Generator.GeneratorContainerBuilder.CreateContainer(SpecFlowConfigurationHolder configurationHolder, ProjectSettings projectSettings)
#error    at TechTalk.SpecFlow.Generator.TestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
#error    at System.Runtime.Remoting.Messaging.StackBuilderSink._PrivateProcessMessage(IntPtr md, Object[] args, Object server, Object[]& outArgs)
#error    at System.Runtime.Remoting.Messaging.StackBuilderSink.SyncProcessMessage(IMessage msg)
#error Exception rethrown at [0]: 
#error    at System.Runtime.Remoting.Proxies.RealProxy.HandleReturnMessage(IMessage reqMsg, IMessage retMsg)
#error    at System.Runtime.Remoting.Proxies.RealProxy.PrivateInvoke(MessageData& msgData, Int32 type)
#error    at TechTalk.SpecFlow.Generator.Interfaces.ITestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
#error    at TechTalk.SpecFlow.IdeIntegration.Generator.RemoteAppDomainTestGeneratorFactory.CreateGenerator(ProjectSettings projectSettings)
#error    at TechTalk.SpecFlow.IdeIntegration.Generator.GeneratorServices.CreateTestGenerator()
#error    at TechTalk.SpecFlow.IdeIntegration.Generator.IdeSingleFileGenerator.GenerateCode(String inputFilePath, String inputFileContent, GeneratorServices generatorServices, ProjectSettings projectSettings)
#error    at TechTalk.SpecFlow.IdeIntegration.Generator.IdeSingleFileGenerator.Generate(String inputFilePath, String inputFileContent, GeneratorServices generatorServices, CodeDomHelper codeDomHelper, ProjectSettings projectSettings)