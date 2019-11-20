namespace Simulation
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    
    [Serializable]
    public partial class SimulationData
    {
        [JsonProperty("Intubation")]
        public string Intubation { get; set; }

        [JsonProperty("SimulationTime")]
        public SimulationTime SimulationTime { get; set; }

        [JsonProperty("Patient")]
        public Patient Patient { get; set; }

        [JsonProperty("Conditions")]
        public ActiveActions Conditions { get; set; }

        [JsonProperty("ActiveActions")]
        public ActiveActions ActiveActions { get; set; }

        [JsonProperty("BloodChemistry")]
        public BloodChemistry BloodChemistry { get; set; }

        [JsonProperty("Cardiovascular")]
        public Cardiovascular Cardiovascular { get; set; }

        [JsonProperty("Drug")]
        public Drug Drug { get; set; }

        [JsonProperty("Endocrine")]
        public Endocrine Endocrine { get; set; }

        [JsonProperty("Energy")]
        public Energy Energy { get; set; }

        [JsonProperty("Gastrointestinal")]
        public Gastrointestinal Gastrointestinal { get; set; }

        [JsonProperty("Hepatic")]
        public Hepatic Hepatic { get; set; }

        [JsonProperty("Nervous")]
        public Nervous Nervous { get; set; }

        [JsonProperty("Renal")]
        public Renal Renal { get; set; }

        [JsonProperty("Respiratory")]
        public Respiratory Respiratory { get; set; }

        [JsonProperty("Tissue")]
        public Tissue Tissue { get; set; }

        [JsonProperty("Environment")]
        public Environment Environment { get; set; }

        [JsonProperty("AnesthesiaMachine")]
        public AnesthesiaMachine AnesthesiaMachine { get; set; }

        [JsonProperty("ElectroCardioGram")]
        public ElectroCardioGram ElectroCardioGram { get; set; }

        [JsonProperty("Inhaler")]
        public Inhaler Inhaler { get; set; }

        [JsonProperty("CompartmentManager")]
        public CompartmentManager CompartmentManager { get; set; }

        [JsonProperty("CircuitManager")]
        public CircuitManager CircuitManager { get; set; }

        [JsonProperty("ActiveSubstance")]
        public List<ActiveSubstance> ActiveSubstance { get; set; }

        [JsonProperty("Configuration")]
        public Configuration Configuration { get; set; }
    }

    public partial class ActiveActions
    {
    }

    public partial class ActiveSubstance
    {
        [JsonProperty("Name")]
        public Name Name { get; set; }

        [JsonProperty("Density", NullValueHandling = NullValueHandling.Ignore)]
        public BodyDensity Density { get; set; }

        [JsonProperty("MolarMass")]
        public MolarMass MolarMass { get; set; }

        [JsonProperty("State")]
        public State State { get; set; }

        [JsonProperty("MassInBody")]
        public LeanBodyMass MassInBody { get; set; }

        [JsonProperty("MassInBlood")]
        public LeanBodyMass MassInBlood { get; set; }

        [JsonProperty("MassInTissue")]
        public LeanBodyMass MassInTissue { get; set; }

        [JsonProperty("PlasmaConcentration")]
        public BodyDensity PlasmaConcentration { get; set; }

        [JsonProperty("AlveolarTransfer", NullValueHandling = NullValueHandling.Ignore)]
        public PuneHedgehog AlveolarTransfer { get; set; }

        [JsonProperty("DiffusingCapacity", NullValueHandling = NullValueHandling.Ignore)]
        public DiffusingCapacity DiffusingCapacity { get; set; }

        [JsonProperty("EndTidalFraction", NullValueHandling = NullValueHandling.Ignore)]
        public BeijingPigeon EndTidalFraction { get; set; }

        [JsonProperty("EndTidalPressure", NullValueHandling = NullValueHandling.Ignore)]
        public TrapaniSnowLeopard EndTidalPressure { get; set; }

        [JsonProperty("RelativeDiffusionCoefficient", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog RelativeDiffusionCoefficient { get; set; }

        [JsonProperty("SolubilityCoefficient", NullValueHandling = NullValueHandling.Ignore)]
        public SolubilityCoefficient SolubilityCoefficient { get; set; }

        [JsonProperty("Clearance")]
        public Clearance Clearance { get; set; }

        [JsonProperty("BloodConcentration", NullValueHandling = NullValueHandling.Ignore)]
        public BodyDensity BloodConcentration { get; set; }

        [JsonProperty("SystemicMassCleared", NullValueHandling = NullValueHandling.Ignore)]
        public LeanBodyMass SystemicMassCleared { get; set; }

        [JsonProperty("Pharmacokinetics", NullValueHandling = NullValueHandling.Ignore)]
        public Pharmacokinetics Pharmacokinetics { get; set; }

        [JsonProperty("Pharmacodynamics", NullValueHandling = NullValueHandling.Ignore)]
        public Pharmacodynamics Pharmacodynamics { get; set; }

        [JsonProperty("MaximumDiffusionFlux", NullValueHandling = NullValueHandling.Ignore)]
        public MaximumDiffusionFlux MaximumDiffusionFlux { get; set; }

        [JsonProperty("MichaelisCoefficient", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog MichaelisCoefficient { get; set; }
    }

    public partial class PuneHedgehog
    {
        [JsonProperty("ScalarVolumePerTime")]
        public TartuGecko ScalarVolumePerTime { get; set; }
    }

    public partial class TartuGecko
    {
        [JsonProperty("Value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }

        [JsonProperty("Unit")]
        public Unit Unit { get; set; }
    }

    public partial class BodyDensity
    {
        [JsonProperty("ScalarMassPerVolume")]
        public TartuGecko ScalarMassPerVolume { get; set; }
    }

    public partial class Clearance
    {
        [JsonProperty("RenalClearance")]
        public RenalClearance RenalClearance { get; set; }

        [JsonProperty("SystemicClearance", NullValueHandling = NullValueHandling.Ignore)]
        public SystemicClearance SystemicClearance { get; set; }
    }

    public partial class RenalClearance
    {
        [JsonProperty("Clearance", NullValueHandling = NullValueHandling.Ignore)]
        public IntrinsicClearanceClass Clearance { get; set; }

        [JsonProperty("GlomerularFilterability")]
        public ArakGroundhog GlomerularFilterability { get; set; }

        [JsonProperty("Regulation", NullValueHandling = NullValueHandling.Ignore)]
        public Regulation Regulation { get; set; }

        [JsonProperty("FiltrationRate", NullValueHandling = NullValueHandling.Ignore)]
        public TionRate FiltrationRate { get; set; }

        [JsonProperty("ReabsorptionRate", NullValueHandling = NullValueHandling.Ignore)]
        public TionRate ReabsorptionRate { get; set; }

        [JsonProperty("ExcretionRate", NullValueHandling = NullValueHandling.Ignore)]
        public TionRate ExcretionRate { get; set; }
    }

    public partial class IntrinsicClearanceClass
    {
        [JsonProperty("ScalarVolumePerTimeMass")]
        public ScalarTimeClass ScalarVolumePerTimeMass { get; set; }
    }

    public partial class ScalarTimeClass
    {
        [JsonProperty("Unit")]
        public Unit Unit { get; set; }
    }

    public partial class TionRate
    {
        [JsonProperty("ScalarMassPerTime")]
        public TartuGecko ScalarMassPerTime { get; set; }
    }

    public partial class ArakGroundhog
    {
        [JsonProperty("Value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }
    }

    public partial class Regulation
    {
        [JsonProperty("ChargeInBlood")]
        public ChargeInBlood ChargeInBlood { get; set; }

        [JsonProperty("FractionUnboundInPlasma")]
        public BeijingPigeon FractionUnboundInPlasma { get; set; }

        [JsonProperty("ReabsorptionRatio")]
        public ReabsorptionRatio ReabsorptionRatio { get; set; }

        [JsonProperty("TransportMaximum")]
        public TransportMaximum TransportMaximum { get; set; }
    }

    public partial class BeijingPigeon
    {
        [JsonProperty("Scalar0To1")]
        public ArakGroundhog Scalar0To1 { get; set; }
    }

    public partial class ReabsorptionRatio
    {
        [JsonProperty("Value", NullValueHandling = NullValueHandling.Ignore)]
        public ValueUnion? Value { get; set; }
    }

    public partial class TransportMaximum
    {
        [JsonProperty("ScalarMassPerTime")]
        public TransportMaximumScalarMassPerTime ScalarMassPerTime { get; set; }
    }

    public partial class TransportMaximumScalarMassPerTime
    {
        [JsonProperty("Value", NullValueHandling = NullValueHandling.Ignore)]
        public ValueUnion? Value { get; set; }

        [JsonProperty("Unit")]
        public Unit Unit { get; set; }
    }

    public partial class SystemicClearance
    {
        [JsonProperty("FractionExcretedInFeces")]
        public CarbonMonoxideSaturation FractionExcretedInFeces { get; set; }

        [JsonProperty("FractionExcretedInUrine")]
        public CarbonMonoxideSaturation FractionExcretedInUrine { get; set; }

        [JsonProperty("FractionMetabolizedInGut")]
        public CarbonMonoxideSaturation FractionMetabolizedInGut { get; set; }

        [JsonProperty("FractionUnboundInPlasma")]
        public BeijingPigeon FractionUnboundInPlasma { get; set; }

        [JsonProperty("IntrinsicClearance")]
        public IntrinsicClearanceClass IntrinsicClearance { get; set; }

        [JsonProperty("RenalClearance")]
        public RenalClearanceClass RenalClearance { get; set; }

        [JsonProperty("SystemicClearance")]
        public RenalClearanceClass SystemicClearanceSystemicClearance { get; set; }
    }

    public partial class CarbonMonoxideSaturation
    {
        [JsonProperty("Scalar0To1")]
        public ActiveActions Scalar0To1 { get; set; }
    }

    public partial class RenalClearanceClass
    {
        [JsonProperty("ScalarVolumePerTimeMass")]
        public TartuGecko ScalarVolumePerTimeMass { get; set; }
    }

    public partial class DiffusingCapacity
    {
        [JsonProperty("ScalarVolumePerTimePressure")]
        public TartuGecko ScalarVolumePerTimePressure { get; set; }
    }

    public partial class TrapaniSnowLeopard
    {
        [JsonProperty("ScalarPressure")]
        public TartuGecko ScalarPressure { get; set; }
    }

    public partial class LeanBodyMass
    {
        [JsonProperty("ScalarMass")]
        public TartuGecko ScalarMass { get; set; }
    }

    public partial class MaximumDiffusionFlux
    {
        [JsonProperty("ScalarMassPerAreaTime")]
        public TartuGecko ScalarMassPerAreaTime { get; set; }
    }

    public partial class MolarMass
    {
        [JsonProperty("ScalarMassPerAmount")]
        public TartuGecko ScalarMassPerAmount { get; set; }
    }

    public partial class Pharmacodynamics
    {
        [JsonProperty("Bronchodilation")]
        public BronchodilationLevel Bronchodilation { get; set; }

        [JsonProperty("DiastolicPressureModifier")]
        public BronchodilationLevel DiastolicPressureModifier { get; set; }

        [JsonProperty("EC50")]
        public BodyDensity Ec50 { get; set; }

        [JsonProperty("EMaxShapeParameter")]
        public ArakGroundhog EMaxShapeParameter { get; set; }

        [JsonProperty("HeartRateModifier")]
        public BronchodilationLevel HeartRateModifier { get; set; }

        [JsonProperty("NeuromuscularBlock")]
        public TubularPermeabilityChange NeuromuscularBlock { get; set; }

        [JsonProperty("PupillaryResponse")]
        public PupillaryResponse PupillaryResponse { get; set; }

        [JsonProperty("RespirationRateModifier")]
        public TubularPermeabilityChange RespirationRateModifier { get; set; }

        [JsonProperty("Sedation")]
        public TubularPermeabilityChange Sedation { get; set; }

        [JsonProperty("SystolicPressureModifier")]
        public BronchodilationLevel SystolicPressureModifier { get; set; }

        [JsonProperty("TidalVolumeModifier")]
        public TubularPermeabilityChange TidalVolumeModifier { get; set; }

        [JsonProperty("TubularPermeabilityModifier")]
        public TubularPermeabilityChange TubularPermeabilityModifier { get; set; }
    }

    public partial class BronchodilationLevel
    {
        [JsonProperty("ScalarNegative1To1")]
        public ArakGroundhog ScalarNegative1To1 { get; set; }
    }

    public partial class TubularPermeabilityChange
    {
        [JsonProperty("ScalarNegative1To1")]
        public ActiveActions ScalarNegative1To1 { get; set; }
    }

    public partial class PupillaryResponse
    {
        [JsonProperty("ReactivityModifier")]
        public TubularPermeabilityChange ReactivityModifier { get; set; }

        [JsonProperty("SizeModifier")]
        public BronchodilationLevel SizeModifier { get; set; }
    }

    public partial class Pharmacokinetics
    {
        [JsonProperty("Physicochemicals")]
        public Physicochemicals Physicochemicals { get; set; }

        [JsonProperty("TissueKinetics")]
        public List<TissueKinetic> TissueKinetics { get; set; }
    }

    public partial class Physicochemicals
    {
        [JsonProperty("AcidDissociationConstant")]
        public ArakGroundhog AcidDissociationConstant { get; set; }

        [JsonProperty("BindingProtein")]
        public string BindingProtein { get; set; }

        [JsonProperty("BloodPlasmaRatio")]
        public ArakGroundhog BloodPlasmaRatio { get; set; }

        [JsonProperty("FractionUnboundInPlasma")]
        public BeijingPigeon FractionUnboundInPlasma { get; set; }

        [JsonProperty("IonicState")]
        public string IonicState { get; set; }

        [JsonProperty("LogP")]
        public ArakGroundhog LogP { get; set; }
    }

    public partial class TissueKinetic
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("PartitionCoefficient")]
        public ArakGroundhog PartitionCoefficient { get; set; }
    }

    public partial class SolubilityCoefficient
    {
        [JsonProperty("ScalarInversePressure")]
        public TartuGecko ScalarInversePressure { get; set; }
    }

    public partial class AnesthesiaMachine
    {
        [JsonProperty("Common")]
        public AnesthesiaMachineCommon Common { get; set; }

        [JsonProperty("Inhaling")]
        public bool Inhaling { get; set; }
    }

    public partial class AnesthesiaMachineCommon
    {
        [JsonProperty("Connection")]
        public string Connection { get; set; }

        [JsonProperty("InletFlow")]
        public PuneHedgehog InletFlow { get; set; }

        [JsonProperty("InspiratoryExpiratoryRatio")]
        public ArakGroundhog InspiratoryExpiratoryRatio { get; set; }

        [JsonProperty("OxygenFraction")]
        public BeijingPigeon OxygenFraction { get; set; }

        [JsonProperty("OxygenSource")]
        public string OxygenSource { get; set; }

        [JsonProperty("PositiveEndExpiredPressure")]
        public TrapaniSnowLeopard PositiveEndExpiredPressure { get; set; }

        [JsonProperty("PrimaryGas")]
        public Name PrimaryGas { get; set; }

        [JsonProperty("ReliefValvePressure")]
        public TrapaniSnowLeopard ReliefValvePressure { get; set; }

        [JsonProperty("RespiratoryRate")]
        public HeartRateBaseline RespiratoryRate { get; set; }

        [JsonProperty("VentilatorPressure")]
        public TrapaniSnowLeopard VentilatorPressure { get; set; }

        [JsonProperty("OxygenBottleOne")]
        public OxygenBottle OxygenBottleOne { get; set; }

        [JsonProperty("OxygenBottleTwo")]
        public OxygenBottle OxygenBottleTwo { get; set; }
    }

    public partial class OxygenBottle
    {
        [JsonProperty("Volume")]
        public ChiangMaiGoose Volume { get; set; }
    }

    public partial class ChiangMaiGoose
    {
        [JsonProperty("ScalarVolume")]
        public TartuGecko ScalarVolume { get; set; }
    }

    public partial class HeartRateBaseline
    {
        [JsonProperty("ScalarFrequency")]
        public TartuGecko ScalarFrequency { get; set; }
    }

    public partial class BloodChemistry
    {
        [JsonProperty("Common")]
        public BloodChemistryCommon Common { get; set; }

        [JsonProperty("ArterialOxygenAverageMmHg")]
        public EsbjergCougar ArterialOxygenAverageMmHg { get; set; }

        [JsonProperty("ArterialCarbonDioxideAverageMmHg")]
        public EsbjergCougar ArterialCarbonDioxideAverageMmHg { get; set; }
    }

    public partial class EsbjergCougar
    {
        [JsonProperty("Sum")]
        public double Sum { get; set; }

        [JsonProperty("NumSamples")]
        public long NumSamples { get; set; }
    }

    public partial class BloodChemistryCommon
    {
        [JsonProperty("BloodDensity")]
        public BodyDensity BloodDensity { get; set; }

        [JsonProperty("BloodPH")]
        public ArakGroundhog BloodPh { get; set; }

        [JsonProperty("BloodSpecificHeat")]
        public SpecificHeat BloodSpecificHeat { get; set; }

        [JsonProperty("BloodUreaNitrogenConcentration")]
        public BodyDensity BloodUreaNitrogenConcentration { get; set; }

        [JsonProperty("CarbonDioxideSaturation")]
        public BeijingPigeon CarbonDioxideSaturation { get; set; }

        [JsonProperty("CarbonMonoxideSaturation")]
        public CarbonMonoxideSaturation CarbonMonoxideSaturation { get; set; }

        [JsonProperty("Hematocrit")]
        public BeijingPigeon Hematocrit { get; set; }

        [JsonProperty("HemoglobinContent")]
        public LeanBodyMass HemoglobinContent { get; set; }

        [JsonProperty("OxygenSaturation")]
        public BeijingPigeon OxygenSaturation { get; set; }

        [JsonProperty("Phosphate")]
        public Phosphate Phosphate { get; set; }

        [JsonProperty("PlasmaVolume")]
        public ChiangMaiGoose PlasmaVolume { get; set; }

        [JsonProperty("PulseOximetry")]
        public BeijingPigeon PulseOximetry { get; set; }

        [JsonProperty("RedBloodCellCount")]
        public Phosphate RedBloodCellCount { get; set; }

        [JsonProperty("ShuntFraction")]
        public BeijingPigeon ShuntFraction { get; set; }

        [JsonProperty("StrongIonDifference")]
        public Phosphate StrongIonDifference { get; set; }

        [JsonProperty("TotalProteinConcentration")]
        public BodyDensity TotalProteinConcentration { get; set; }

        [JsonProperty("VolumeFractionNeutralLipidInPlasma")]
        public BeijingPigeon VolumeFractionNeutralLipidInPlasma { get; set; }

        [JsonProperty("VolumeFractionNeutralPhospholipidInPlasma")]
        public BeijingPigeon VolumeFractionNeutralPhospholipidInPlasma { get; set; }

        [JsonProperty("WhiteBloodCellCount")]
        public Phosphate WhiteBloodCellCount { get; set; }

        [JsonProperty("ArterialCarbonDioxidePressure")]
        public TrapaniSnowLeopard ArterialCarbonDioxidePressure { get; set; }

        [JsonProperty("ArterialOxygenPressure")]
        public TrapaniSnowLeopard ArterialOxygenPressure { get; set; }

        [JsonProperty("PulmonaryArterialCarbonDioxidePressure")]
        public TrapaniSnowLeopard PulmonaryArterialCarbonDioxidePressure { get; set; }

        [JsonProperty("PulmonaryArterialOxygenPressure")]
        public TrapaniSnowLeopard PulmonaryArterialOxygenPressure { get; set; }

        [JsonProperty("PulmonaryVenousCarbonDioxidePressure")]
        public TrapaniSnowLeopard PulmonaryVenousCarbonDioxidePressure { get; set; }

        [JsonProperty("PulmonaryVenousOxygenPressure")]
        public TrapaniSnowLeopard PulmonaryVenousOxygenPressure { get; set; }

        [JsonProperty("VenousCarbonDioxidePressure")]
        public TrapaniSnowLeopard VenousCarbonDioxidePressure { get; set; }

        [JsonProperty("VenousOxygenPressure")]
        public TrapaniSnowLeopard VenousOxygenPressure { get; set; }
    }

    public partial class SpecificHeat
    {
        [JsonProperty("ScalarHeatCapacitancePerMass")]
        public TartuGecko ScalarHeatCapacitancePerMass { get; set; }
    }

    public partial class Phosphate
    {
        [JsonProperty("ScalarAmountPerVolume")]
        public TartuGecko ScalarAmountPerVolume { get; set; }
    }

    public partial class Cardiovascular
    {
        [JsonProperty("Common")]
        public CardiovascularCommon Common { get; set; }

        [JsonProperty("HeartFlowDetected")]
        public bool HeartFlowDetected { get; set; }

        [JsonProperty("CardiacCyclePeriodS")]
        public double CardiacCyclePeriodS { get; set; }

        [JsonProperty("CurrentCardiacCycleDurationS")]
        public double CurrentCardiacCycleDurationS { get; set; }

        [JsonProperty("LeftHeartElastanceModifier")]
        public long LeftHeartElastanceModifier { get; set; }

        [JsonProperty("LeftHeartElastanceMmHgPerML")]
        public double LeftHeartElastanceMmHgPerMl { get; set; }

        [JsonProperty("LeftHeartElastanceMaxMmHgPerML")]
        public double LeftHeartElastanceMaxMmHgPerMl { get; set; }

        [JsonProperty("LeftHeartElastanceMinMmHgPerML")]
        public double LeftHeartElastanceMinMmHgPerMl { get; set; }

        [JsonProperty("RightHeartElastanceMmHgPerML")]
        public double RightHeartElastanceMmHgPerMl { get; set; }

        [JsonProperty("RightHeartElastanceMaxMmHgPerML")]
        public double RightHeartElastanceMaxMmHgPerMl { get; set; }

        [JsonProperty("RightHeartElastanceMinMmHgPerML")]
        public double RightHeartElastanceMinMmHgPerMl { get; set; }

        [JsonProperty("CurrentCardiacCycleTimeS")]
        public double CurrentCardiacCycleTimeS { get; set; }

        [JsonProperty("CardiacCycleDiastolicVolumeML")]
        public double CardiacCycleDiastolicVolumeMl { get; set; }

        [JsonProperty("CardiacCycleAortaPressureLowMmHg")]
        public double CardiacCycleAortaPressureLowMmHg { get; set; }

        [JsonProperty("CardiacCycleAortaPressureHighMmHg")]
        public double CardiacCycleAortaPressureHighMmHg { get; set; }

        [JsonProperty("CardiacCyclePulmonaryArteryPressureLowMmHg")]
        public double CardiacCyclePulmonaryArteryPressureLowMmHg { get; set; }

        [JsonProperty("CardiacCyclePulmonaryArteryPressureHighMmHg")]
        public double CardiacCyclePulmonaryArteryPressureHighMmHg { get; set; }

        [JsonProperty("LastCardiacCycleMeanArterialCO2PartialPressureMmHg")]
        public double LastCardiacCycleMeanArterialCo2PartialPressureMmHg { get; set; }

        [JsonProperty("CardiacCycleStrokeVolumeML")]
        public double CardiacCycleStrokeVolumeMl { get; set; }

        [JsonProperty("CardiacCycleArterialPressureMmHg")]
        public EsbjergCougar CardiacCycleArterialPressureMmHg { get; set; }

        [JsonProperty("CardiacCycleArterialCO2PartialPressureMmHg")]
        public EsbjergCougar CardiacCycleArterialCo2PartialPressureMmHg { get; set; }

        [JsonProperty("CardiacCyclePulmonaryCapillariesWedgePressureMmHg")]
        public EsbjergCougar CardiacCyclePulmonaryCapillariesWedgePressureMmHg { get; set; }

        [JsonProperty("CardiacCyclePulmonaryCapillariesFlowMLPerS")]
        public EsbjergCougar CardiacCyclePulmonaryCapillariesFlowMlPerS { get; set; }

        [JsonProperty("CardiacCyclePulmonaryShuntFlowMLPerS")]
        public EsbjergCougar CardiacCyclePulmonaryShuntFlowMlPerS { get; set; }

        [JsonProperty("CardiacCyclePulmonaryArteryPressureMmHg")]
        public EsbjergCougar CardiacCyclePulmonaryArteryPressureMmHg { get; set; }

        [JsonProperty("CardiacCycleCentralVenousPressureMmHg")]
        public EsbjergCougar CardiacCycleCentralVenousPressureMmHg { get; set; }

        [JsonProperty("CardiacCycleSkinFlowMLPerS")]
        public EsbjergCougar CardiacCycleSkinFlowMlPerS { get; set; }
    }

    public partial class CardiovascularCommon
    {
        [JsonProperty("ArterialPressure")]
        public TrapaniSnowLeopard ArterialPressure { get; set; }

        [JsonProperty("BloodVolume")]
        public ChiangMaiGoose BloodVolume { get; set; }

        [JsonProperty("CardiacIndex")]
        public CardiacIndex CardiacIndex { get; set; }

        [JsonProperty("CardiacOutput")]
        public PuneHedgehog CardiacOutput { get; set; }

        [JsonProperty("CentralVenousPressure")]
        public TrapaniSnowLeopard CentralVenousPressure { get; set; }

        [JsonProperty("CerebralBloodFlow")]
        public PuneHedgehog CerebralBloodFlow { get; set; }

        [JsonProperty("CerebralPerfusionPressure")]
        public TrapaniSnowLeopard CerebralPerfusionPressure { get; set; }

        [JsonProperty("DiastolicArterialPressure")]
        public TrapaniSnowLeopard DiastolicArterialPressure { get; set; }

        [JsonProperty("HeartEjectionFraction")]
        public BeijingPigeon HeartEjectionFraction { get; set; }

        [JsonProperty("HeartRate")]
        public HeartRateBaseline HeartRate { get; set; }

        [JsonProperty("HeartStrokeVolume")]
        public ChiangMaiGoose HeartStrokeVolume { get; set; }

        [JsonProperty("IntracranialPressure")]
        public TrapaniSnowLeopard IntracranialPressure { get; set; }

        [JsonProperty("MeanArterialPressure")]
        public TrapaniSnowLeopard MeanArterialPressure { get; set; }

        [JsonProperty("MeanArterialCarbonDioxidePartialPressure")]
        public TrapaniSnowLeopard MeanArterialCarbonDioxidePartialPressure { get; set; }

        [JsonProperty("MeanArterialCarbonDioxidePartialPressureDelta")]
        public TrapaniSnowLeopard MeanArterialCarbonDioxidePartialPressureDelta { get; set; }

        [JsonProperty("MeanCentralVenousPressure")]
        public TrapaniSnowLeopard MeanCentralVenousPressure { get; set; }

        [JsonProperty("MeanSkinFlow")]
        public PuneHedgehog MeanSkinFlow { get; set; }

        [JsonProperty("PulmonaryArterialPressure")]
        public TrapaniSnowLeopard PulmonaryArterialPressure { get; set; }

        [JsonProperty("PulmonaryCapillariesWedgePressure")]
        public TrapaniSnowLeopard PulmonaryCapillariesWedgePressure { get; set; }

        [JsonProperty("PulmonaryDiastolicArterialPressure")]
        public TrapaniSnowLeopard PulmonaryDiastolicArterialPressure { get; set; }

        [JsonProperty("PulmonaryMeanArterialPressure")]
        public TrapaniSnowLeopard PulmonaryMeanArterialPressure { get; set; }

        [JsonProperty("PulmonaryMeanCapillaryFlow")]
        public PuneHedgehog PulmonaryMeanCapillaryFlow { get; set; }

        [JsonProperty("PulmonaryMeanShuntFlow")]
        public PuneHedgehog PulmonaryMeanShuntFlow { get; set; }

        [JsonProperty("PulmonarySystolicArterialPressure")]
        public TrapaniSnowLeopard PulmonarySystolicArterialPressure { get; set; }

        [JsonProperty("PulmonaryVascularResistance")]
        public PulmonaryVascularResistance PulmonaryVascularResistance { get; set; }

        [JsonProperty("PulmonaryVascularResistanceIndex")]
        public PulmonaryVascularResistanceIndex PulmonaryVascularResistanceIndex { get; set; }

        [JsonProperty("PulsePressure")]
        public TrapaniSnowLeopard PulsePressure { get; set; }

        [JsonProperty("SystemicVascularResistance")]
        public PulmonaryVascularResistance SystemicVascularResistance { get; set; }

        [JsonProperty("SystolicArterialPressure")]
        public TrapaniSnowLeopard SystolicArterialPressure { get; set; }
    }

    public partial class CardiacIndex
    {
        [JsonProperty("ScalarVolumePerTimeArea")]
        public TartuGecko ScalarVolumePerTimeArea { get; set; }
    }

    public partial class PulmonaryVascularResistance
    {
        [JsonProperty("ScalarFlowResistance")]
        public TartuGecko ScalarFlowResistance { get; set; }
    }

    public partial class PulmonaryVascularResistanceIndex
    {
        [JsonProperty("ScalarPressureTimePerVolumeArea")]
        public TartuGecko ScalarPressureTimePerVolumeArea { get; set; }
    }

    public partial class CircuitManager
    {
        [JsonProperty("FluidNode")]
        public List<FluidNode> FluidNode { get; set; }

        [JsonProperty("FluidPath")]
        public List<FluidPath> FluidPath { get; set; }

        [JsonProperty("FluidCircuit")]
        public List<Circuit> FluidCircuit { get; set; }

        [JsonProperty("ThermalNode")]
        public List<ThermalNode> ThermalNode { get; set; }

        [JsonProperty("ThermalPath")]
        public List<ThermalPath> ThermalPath { get; set; }

        [JsonProperty("ThermalCircuit")]
        public List<Circuit> ThermalCircuit { get; set; }
    }

    public partial class Circuit
    {
        [JsonProperty("Circuit")]
        public CircuitClass CircuitCircuit { get; set; }
    }

    public partial class CircuitClass
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Node")]
        public List<string> Node { get; set; }

        [JsonProperty("Path")]
        public List<string> Path { get; set; }
    }

    public partial class FluidNode
    {
        [JsonProperty("CircuitNode")]
        public CircuitNode CircuitNode { get; set; }

        [JsonProperty("Pressure", NullValueHandling = NullValueHandling.Ignore)]
        public NextPressure Pressure { get; set; }

        [JsonProperty("NextPressure", NullValueHandling = NullValueHandling.Ignore)]
        public NextPressure NextPressure { get; set; }

        [JsonProperty("Volume", NullValueHandling = NullValueHandling.Ignore)]
        public NextVolume Volume { get; set; }

        [JsonProperty("NextVolume", NullValueHandling = NullValueHandling.Ignore)]
        public NextVolume NextVolume { get; set; }

        [JsonProperty("VolumeBaseline", NullValueHandling = NullValueHandling.Ignore)]
        public NextVolume VolumeBaseline { get; set; }
    }

    public partial class CircuitNode
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("ReferenceNode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReferenceNode { get; set; }
    }

    public partial class NextPressure
    {
        [JsonProperty("ScalarPressure")]
        public ScalarFlowComplianceClass ScalarPressure { get; set; }
    }

    public partial class ScalarFlowComplianceClass
    {
        [JsonProperty("Unit")]
        public PurpleUnit Unit { get; set; }

        [JsonProperty("ReadOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReadOnly { get; set; }

        [JsonProperty("Value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value { get; set; }
    }

    public partial class NextVolume
    {
        [JsonProperty("ScalarVolume")]
        public ScalarVolume ScalarVolume { get; set; }
    }

    public partial class ScalarVolume
    {
        [JsonProperty("Value", NullValueHandling = NullValueHandling.Ignore)]
        public ValueUnion? Value { get; set; }

        [JsonProperty("Unit")]
        public Unit Unit { get; set; }

        [JsonProperty("ReadOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReadOnly { get; set; }
    }

    public partial class FluidPath
    {
        [JsonProperty("CircuitPath")]
        public FluidPathCircuitPath CircuitPath { get; set; }

        [JsonProperty("Compliance", NullValueHandling = NullValueHandling.Ignore)]
        public Compliance Compliance { get; set; }

        [JsonProperty("NextCompliance", NullValueHandling = NullValueHandling.Ignore)]
        public PulmonaryCompliance NextCompliance { get; set; }

        [JsonProperty("ComplianceBaseline", NullValueHandling = NullValueHandling.Ignore)]
        public PulmonaryCompliance ComplianceBaseline { get; set; }

        [JsonProperty("Flow", NullValueHandling = NullValueHandling.Ignore)]
        public Flow Flow { get; set; }

        [JsonProperty("NextFlow", NullValueHandling = NullValueHandling.Ignore)]
        public Flow NextFlow { get; set; }

        [JsonProperty("Resistance", NullValueHandling = NullValueHandling.Ignore)]
        public FluidPathResistance Resistance { get; set; }

        [JsonProperty("NextResistance", NullValueHandling = NullValueHandling.Ignore)]
        public PulmonaryVascularResistance NextResistance { get; set; }

        [JsonProperty("ResistanceBaseline", NullValueHandling = NullValueHandling.Ignore)]
        public PulmonaryVascularResistance ResistanceBaseline { get; set; }

        [JsonProperty("PressureSource", NullValueHandling = NullValueHandling.Ignore)]
        public NextPressure PressureSource { get; set; }

        [JsonProperty("NextPressureSource", NullValueHandling = NullValueHandling.Ignore)]
        public TrapaniSnowLeopard NextPressureSource { get; set; }

        [JsonProperty("PressureSourceBaseline", NullValueHandling = NullValueHandling.Ignore)]
        public TrapaniSnowLeopard PressureSourceBaseline { get; set; }

        [JsonProperty("FlowSource", NullValueHandling = NullValueHandling.Ignore)]
        public Flow FlowSource { get; set; }

        [JsonProperty("NextFlowSource", NullValueHandling = NullValueHandling.Ignore)]
        public UrinationRate NextFlowSource { get; set; }

        [JsonProperty("FlowSourceBaseline", NullValueHandling = NullValueHandling.Ignore)]
        public UrinationRate FlowSourceBaseline { get; set; }
    }

    public partial class FluidPathCircuitPath
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("SourceNode")]
        public string SourceNode { get; set; }

        [JsonProperty("TargetNode")]
        public string TargetNode { get; set; }

        [JsonProperty("Valve", NullValueHandling = NullValueHandling.Ignore)]
        public NextPolarizedState? Valve { get; set; }

        [JsonProperty("NextValve", NullValueHandling = NullValueHandling.Ignore)]
        public NextPolarizedState? NextValve { get; set; }

        [JsonProperty("PolarizedState", NullValueHandling = NullValueHandling.Ignore)]
        public NextPolarizedState? PolarizedState { get; set; }

        [JsonProperty("NextPolarizedState", NullValueHandling = NullValueHandling.Ignore)]
        public NextPolarizedState? NextPolarizedState { get; set; }
    }

    public partial class Compliance
    {
        [JsonProperty("ScalarFlowCompliance")]
        public ScalarFlowComplianceClass ScalarFlowCompliance { get; set; }
    }

    public partial class PulmonaryCompliance
    {
        [JsonProperty("ScalarFlowCompliance")]
        public TartuGecko ScalarFlowCompliance { get; set; }
    }

    public partial class Flow
    {
        [JsonProperty("ScalarVolumePerTime")]
        public ScalarFlowComplianceClass ScalarVolumePerTime { get; set; }
    }

    public partial class UrinationRate
    {
        [JsonProperty("ScalarVolumePerTime")]
        public ScalarTimeClass ScalarVolumePerTime { get; set; }
    }

    public partial class FluidPathResistance
    {
        [JsonProperty("ScalarFlowResistance")]
        public ScalarFlowComplianceClass ScalarFlowResistance { get; set; }
    }

    public partial class ThermalNode
    {
        [JsonProperty("CircuitNode")]
        public CircuitNode CircuitNode { get; set; }

        [JsonProperty("Temperature")]
        public NextTemperature Temperature { get; set; }

        [JsonProperty("NextTemperature")]
        public NextTemperature NextTemperature { get; set; }

        [JsonProperty("Heat", NullValueHandling = NullValueHandling.Ignore)]
        public Heat Heat { get; set; }

        [JsonProperty("NextHeat", NullValueHandling = NullValueHandling.Ignore)]
        public Heat NextHeat { get; set; }

        [JsonProperty("HeatBaseline", NullValueHandling = NullValueHandling.Ignore)]
        public Heat HeatBaseline { get; set; }
    }

    public partial class Heat
    {
        [JsonProperty("ScalarEnergy")]
        public ScalarFlowComplianceClass ScalarEnergy { get; set; }
    }

    public partial class NextTemperature
    {
        [JsonProperty("ScalarTemperature")]
        public ScalarFlowComplianceClass ScalarTemperature { get; set; }
    }

    public partial class ThermalPath
    {
        [JsonProperty("CircuitPath")]
        public ThermalPathCircuitPath CircuitPath { get; set; }

        [JsonProperty("HeatTransferRate")]
        public HeatSource HeatTransferRate { get; set; }

        [JsonProperty("NextHeatTransferRate")]
        public HeatSource NextHeatTransferRate { get; set; }

        [JsonProperty("Resistance", NullValueHandling = NullValueHandling.Ignore)]
        public ThermalPathResistance Resistance { get; set; }

        [JsonProperty("NextResistance", NullValueHandling = NullValueHandling.Ignore)]
        public DefaultClosedHeatResistance NextResistance { get; set; }

        [JsonProperty("HeatSource", NullValueHandling = NullValueHandling.Ignore)]
        public HeatSource HeatSource { get; set; }

        [JsonProperty("NextHeatSource", NullValueHandling = NullValueHandling.Ignore)]
        public BasalMetabolicRate NextHeatSource { get; set; }

        [JsonProperty("TemperatureSource", NullValueHandling = NullValueHandling.Ignore)]
        public NextTemperature TemperatureSource { get; set; }

        [JsonProperty("NextTemperatureSource", NullValueHandling = NullValueHandling.Ignore)]
        public CoreTemperatureHigh NextTemperatureSource { get; set; }

        [JsonProperty("HeatSourceBaseline", NullValueHandling = NullValueHandling.Ignore)]
        public HeatSourceBaseline HeatSourceBaseline { get; set; }

        [JsonProperty("Capacitance", NullValueHandling = NullValueHandling.Ignore)]
        public Capacitance Capacitance { get; set; }

        [JsonProperty("NextCapacitance", NullValueHandling = NullValueHandling.Ignore)]
        public CapacitanceBaseline NextCapacitance { get; set; }

        [JsonProperty("CapacitanceBaseline", NullValueHandling = NullValueHandling.Ignore)]
        public CapacitanceBaseline CapacitanceBaseline { get; set; }

        [JsonProperty("ResistanceBaseline", NullValueHandling = NullValueHandling.Ignore)]
        public DefaultClosedHeatResistance ResistanceBaseline { get; set; }
    }

    public partial class Capacitance
    {
        [JsonProperty("ScalarHeatCapacitance")]
        public ScalarFlowComplianceClass ScalarHeatCapacitance { get; set; }
    }

    public partial class CapacitanceBaseline
    {
        [JsonProperty("ScalarHeatCapacitance")]
        public TartuGecko ScalarHeatCapacitance { get; set; }
    }

    public partial class ThermalPathCircuitPath
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("SourceNode")]
        public string SourceNode { get; set; }

        [JsonProperty("TargetNode")]
        public string TargetNode { get; set; }

        [JsonProperty("Switch", NullValueHandling = NullValueHandling.Ignore)]
        public NextPolarizedState? Switch { get; set; }

        [JsonProperty("NextSwitch", NullValueHandling = NullValueHandling.Ignore)]
        public NextPolarizedState? NextSwitch { get; set; }
    }

    public partial class HeatSource
    {
        [JsonProperty("ScalarPower")]
        public ScalarFlowComplianceClass ScalarPower { get; set; }
    }

    public partial class HeatSourceBaseline
    {
        [JsonProperty("ScalarPower")]
        public ScalarTimeClass ScalarPower { get; set; }
    }

    public partial class BasalMetabolicRate
    {
        [JsonProperty("ScalarPower")]
        public TartuGecko ScalarPower { get; set; }
    }

    public partial class DefaultClosedHeatResistance
    {
        [JsonProperty("ScalarHeatResistance")]
        public TartuGecko ScalarHeatResistance { get; set; }
    }

    public partial class CoreTemperatureHigh
    {
        [JsonProperty("ScalarTemperature")]
        public TartuGecko ScalarTemperature { get; set; }
    }

    public partial class ThermalPathResistance
    {
        [JsonProperty("ScalarHeatResistance")]
        public ScalarFlowComplianceClass ScalarHeatResistance { get; set; }
    }

    public partial class CompartmentManager
    {
        [JsonProperty("LiquidCompartment")]
        public List<LiquidCompartment> LiquidCompartment { get; set; }

        [JsonProperty("LiquidLink")]
        public List<Link> LiquidLink { get; set; }

        [JsonProperty("LiquidSubstance")]
        public List<Name> LiquidSubstance { get; set; }

        [JsonProperty("LiquidGraph")]
        public List<Graph> LiquidGraph { get; set; }

        [JsonProperty("GasCompartment")]
        public List<GasCompartment> GasCompartment { get; set; }

        [JsonProperty("GasLink")]
        public List<Link> GasLink { get; set; }

        [JsonProperty("GasSubstance")]
        public List<Name> GasSubstance { get; set; }

        [JsonProperty("GasGraph")]
        public List<Graph> GasGraph { get; set; }

        [JsonProperty("ThermalCompartment")]
        public List<ThermalCompartment> ThermalCompartment { get; set; }

        [JsonProperty("ThermalLink")]
        public List<ThermalLink> ThermalLink { get; set; }

        [JsonProperty("TissueCompartment")]
        public List<TissueCompartment> TissueCompartment { get; set; }
    }

    public partial class GasCompartment
    {
        [JsonProperty("FluidCompartment")]
        public FluidCompartment FluidCompartment { get; set; }

        [JsonProperty("SubstanceQuantity")]
        public List<GasCompartmentSubstanceQuantity> SubstanceQuantity { get; set; }
    }

    public partial class FluidCompartment
    {
        [JsonProperty("Compartment")]
        public FluidCompartmentCompartment Compartment { get; set; }

        [JsonProperty("InFlow", NullValueHandling = NullValueHandling.Ignore)]
        public Flow InFlow { get; set; }

        [JsonProperty("OutFlow", NullValueHandling = NullValueHandling.Ignore)]
        public Flow OutFlow { get; set; }

        [JsonProperty("Pressure", NullValueHandling = NullValueHandling.Ignore)]
        public NextPressure Pressure { get; set; }

        [JsonProperty("Volume", NullValueHandling = NullValueHandling.Ignore)]
        public NextVolume Volume { get; set; }
    }

    public partial class FluidCompartmentCompartment
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Node", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Node { get; set; }

        [JsonProperty("Child", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Child { get; set; }
    }

    public partial class GasCompartmentSubstanceQuantity
    {
        [JsonProperty("SubstanceQuantity")]
        public SubstanceQuantitySubstanceQuantity SubstanceQuantity { get; set; }

        [JsonProperty("PartialPressure", NullValueHandling = NullValueHandling.Ignore)]
        public TrapaniSnowLeopard PartialPressure { get; set; }

        [JsonProperty("Volume", NullValueHandling = NullValueHandling.Ignore)]
        public Volume Volume { get; set; }

        [JsonProperty("VolumeFraction", NullValueHandling = NullValueHandling.Ignore)]
        public BeijingPigeon VolumeFraction { get; set; }
    }

    public partial class SubstanceQuantitySubstanceQuantity
    {
        [JsonProperty("Substance")]
        public Name Substance { get; set; }
    }

    public partial class Volume
    {
        [JsonProperty("ScalarVolume")]
        public TransportMaximumScalarMassPerTime ScalarVolume { get; set; }
    }

    public partial class Graph
    {
        [JsonProperty("FluidGraph")]
        public FluidGraph FluidGraph { get; set; }
    }

    public partial class FluidGraph
    {
        [JsonProperty("Graph")]
        public GraphClass Graph { get; set; }
    }

    public partial class GraphClass
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Compartment")]
        public List<string> Compartment { get; set; }

        [JsonProperty("Link")]
        public List<string> Link { get; set; }
    }

    public partial class Link
    {
        [JsonProperty("FluidLink")]
        public FluidLink FluidLink { get; set; }
    }

    public partial class FluidLink
    {
        [JsonProperty("Link")]
        public LinkClass Link { get; set; }

        [JsonProperty("Flow", NullValueHandling = NullValueHandling.Ignore)]
        public Flow Flow { get; set; }
    }

    public partial class LinkClass
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Path")]
        public string Path { get; set; }

        [JsonProperty("SourceCompartment")]
        public string SourceCompartment { get; set; }

        [JsonProperty("TargetCompartment")]
        public string TargetCompartment { get; set; }
    }

    public partial class LiquidCompartment
    {
        [JsonProperty("FluidCompartment")]
        public FluidCompartment FluidCompartment { get; set; }

        [JsonProperty("SubstanceQuantity", NullValueHandling = NullValueHandling.Ignore)]
        public List<LiquidCompartmentSubstanceQuantity> SubstanceQuantity { get; set; }

        [JsonProperty("pH", NullValueHandling = NullValueHandling.Ignore)]
        public ArakGroundhog PH { get; set; }

        [JsonProperty("WaterVolumeFraction", NullValueHandling = NullValueHandling.Ignore)]
        public BeijingPigeon WaterVolumeFraction { get; set; }
    }

    public partial class LiquidCompartmentSubstanceQuantity
    {
        [JsonProperty("SubstanceQuantity")]
        public SubstanceQuantitySubstanceQuantity SubstanceQuantity { get; set; }

        [JsonProperty("Concentration", NullValueHandling = NullValueHandling.Ignore)]
        public Concentration Concentration { get; set; }

        [JsonProperty("Mass", NullValueHandling = NullValueHandling.Ignore)]
        public LeanBodyMass Mass { get; set; }

        [JsonProperty("MassCleared", NullValueHandling = NullValueHandling.Ignore)]
        public LeanBodyMass MassCleared { get; set; }

        [JsonProperty("MassDeposited", NullValueHandling = NullValueHandling.Ignore)]
        public MassDeposited MassDeposited { get; set; }

        [JsonProperty("MassExcreted", NullValueHandling = NullValueHandling.Ignore)]
        public LeanBodyMass MassExcreted { get; set; }

        [JsonProperty("Molarity")]
        public Molarity Molarity { get; set; }

        [JsonProperty("PartialPressure", NullValueHandling = NullValueHandling.Ignore)]
        public NextPressure PartialPressure { get; set; }

        [JsonProperty("Saturation", NullValueHandling = NullValueHandling.Ignore)]
        public BeijingPigeon Saturation { get; set; }
    }

    public partial class Concentration
    {
        [JsonProperty("ScalarMassPerVolume")]
        public ScalarFlowComplianceClass ScalarMassPerVolume { get; set; }
    }

    public partial class MassDeposited
    {
        [JsonProperty("ScalarMass")]
        public ScalarTimeClass ScalarMass { get; set; }
    }

    public partial class Molarity
    {
        [JsonProperty("ScalarAmountPerVolume")]
        public ScalarFlowComplianceClass ScalarAmountPerVolume { get; set; }
    }

    public partial class ThermalCompartment
    {
        [JsonProperty("Compartment")]
        public ThermalCompartmentCompartment Compartment { get; set; }

        [JsonProperty("HeatTransferRateIn")]
        public HeatSource HeatTransferRateIn { get; set; }

        [JsonProperty("HeatTransferRateOut")]
        public HeatSource HeatTransferRateOut { get; set; }

        [JsonProperty("Temperature", NullValueHandling = NullValueHandling.Ignore)]
        public NextTemperature Temperature { get; set; }

        [JsonProperty("Heat", NullValueHandling = NullValueHandling.Ignore)]
        public Heat Heat { get; set; }
    }

    public partial class ThermalCompartmentCompartment
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Node", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Node { get; set; }
    }

    public partial class ThermalLink
    {
        [JsonProperty("Link")]
        public LinkClass Link { get; set; }

        [JsonProperty("HeatTransferRate")]
        public HeatSource HeatTransferRate { get; set; }
    }

    public partial class TissueCompartment
    {
        [JsonProperty("Compartment")]
        public TissueCompartmentCompartment Compartment { get; set; }

        [JsonProperty("AcidicPhospohlipidConcentration")]
        public AcidicPhospohlipidConcentration AcidicPhospohlipidConcentration { get; set; }

        [JsonProperty("MatrixVolume")]
        public ChiangMaiGoose MatrixVolume { get; set; }

        [JsonProperty("NeutralLipidsVolumeFraction")]
        public BeijingPigeon NeutralLipidsVolumeFraction { get; set; }

        [JsonProperty("NeutralPhospholipidsVolumeFraction")]
        public BeijingPigeon NeutralPhospholipidsVolumeFraction { get; set; }

        [JsonProperty("TissueToPlasmaAlbuminRatio")]
        public ArakGroundhog TissueToPlasmaAlbuminRatio { get; set; }

        [JsonProperty("TissueToPlasmaAlphaAcidGlycoproteinRatio")]
        public ArakGroundhog TissueToPlasmaAlphaAcidGlycoproteinRatio { get; set; }

        [JsonProperty("TissueToPlasmaLipoproteinRatio")]
        public ArakGroundhog TissueToPlasmaLipoproteinRatio { get; set; }

        [JsonProperty("TotalMass")]
        public LeanBodyMass TotalMass { get; set; }
    }

    public partial class AcidicPhospohlipidConcentration
    {
        [JsonProperty("ScalarMassPerMass")]
        public TartuGecko ScalarMassPerMass { get; set; }
    }

    public partial class TissueCompartmentCompartment
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
    }

    public partial class Configuration
    {
        [JsonProperty("TimeStep")]
        public TimeStep TimeStep { get; set; }

        [JsonProperty("DynamicStabilization")]
        public DynamicStabilization DynamicStabilization { get; set; }

        [JsonProperty("WritePatientBaselineFile")]
        public string WritePatientBaselineFile { get; set; }

        [JsonProperty("BaroreceptorConfiguration")]
        public BaroreceptorConfiguration BaroreceptorConfiguration { get; set; }

        [JsonProperty("BloodChemistryConfiguration")]
        public BloodChemistryConfiguration BloodChemistryConfiguration { get; set; }

        [JsonProperty("CardiovascularConfiguration")]
        public CardiovascularConfiguration CardiovascularConfiguration { get; set; }

        [JsonProperty("CircuitConfiguration")]
        public CircuitConfiguration CircuitConfiguration { get; set; }

        [JsonProperty("ConstantsConfiguration")]
        public ConstantsConfiguration ConstantsConfiguration { get; set; }

        [JsonProperty("DrugsConfiguration")]
        public DrugsConfiguration DrugsConfiguration { get; set; }

        [JsonProperty("EnergyConfiguration")]
        public EnergyConfiguration EnergyConfiguration { get; set; }

        [JsonProperty("EnvironmentConfiguration")]
        public EnvironmentConfiguration EnvironmentConfiguration { get; set; }

        [JsonProperty("GastrointestinalConfiguration")]
        public GastrointestinalConfiguration GastrointestinalConfiguration { get; set; }

        [JsonProperty("NervousConfiguration")]
        public NervousConfiguration NervousConfiguration { get; set; }

        [JsonProperty("RenalConfiguration")]
        public RenalConfiguration RenalConfiguration { get; set; }

        [JsonProperty("RespiratoryConfiguration")]
        public RespiratoryConfiguration RespiratoryConfiguration { get; set; }

        [JsonProperty("TissueConfiguration")]
        public TissueConfiguration TissueConfiguration { get; set; }
    }

    public partial class BaroreceptorConfiguration
    {
        [JsonProperty("ResponseSlope")]
        public ArakGroundhog ResponseSlope { get; set; }

        [JsonProperty("HeartRateDistributedTimeDelay")]
        public TimeStep HeartRateDistributedTimeDelay { get; set; }

        [JsonProperty("HeartElastanceDistributedTimeDelay")]
        public TimeStep HeartElastanceDistributedTimeDelay { get; set; }

        [JsonProperty("SystemicResistanceDistributedTimeDelay")]
        public TimeStep SystemicResistanceDistributedTimeDelay { get; set; }

        [JsonProperty("VenousComplianceDistributedTimeDelay")]
        public TimeStep VenousComplianceDistributedTimeDelay { get; set; }

        [JsonProperty("NormalizedHeartRateIntercept")]
        public ArakGroundhog NormalizedHeartRateIntercept { get; set; }

        [JsonProperty("NormalizedHeartRateSympatheticSlope")]
        public ArakGroundhog NormalizedHeartRateSympatheticSlope { get; set; }

        [JsonProperty("NormalizedHeartRateParasympatheticSlope")]
        public ArakGroundhog NormalizedHeartRateParasympatheticSlope { get; set; }

        [JsonProperty("NormalizedHeartElastanceIntercept")]
        public ArakGroundhog NormalizedHeartElastanceIntercept { get; set; }

        [JsonProperty("NormalizedHeartElastanceSympatheticSlope")]
        public ArakGroundhog NormalizedHeartElastanceSympatheticSlope { get; set; }

        [JsonProperty("NormalizedResistanceIntercept")]
        public ArakGroundhog NormalizedResistanceIntercept { get; set; }

        [JsonProperty("NormalizedResistanceSympatheticSlope")]
        public ArakGroundhog NormalizedResistanceSympatheticSlope { get; set; }

        [JsonProperty("NormalizedComplianceIntercept")]
        public ArakGroundhog NormalizedComplianceIntercept { get; set; }

        [JsonProperty("NormalizedComplianceParasympatheticSlope")]
        public ArakGroundhog NormalizedComplianceParasympatheticSlope { get; set; }
    }

    public partial class TimeStep
    {
        [JsonProperty("ScalarTime")]
        public TartuGecko ScalarTime { get; set; }
    }

    public partial class BloodChemistryConfiguration
    {
        [JsonProperty("MeanCorpuscularHemoglobin")]
        public MolarMass MeanCorpuscularHemoglobin { get; set; }

        [JsonProperty("MeanCorpuscularVolume")]
        public ChiangMaiGoose MeanCorpuscularVolume { get; set; }

        [JsonProperty("StandardDiffusionDistance")]
        public Height StandardDiffusionDistance { get; set; }

        [JsonProperty("StandardOxygenDiffusionCoefficient")]
        public StandardOxygenDiffusionCoefficient StandardOxygenDiffusionCoefficient { get; set; }
    }

    public partial class Height
    {
        [JsonProperty("ScalarLength")]
        public TartuGecko ScalarLength { get; set; }
    }

    public partial class StandardOxygenDiffusionCoefficient
    {
        [JsonProperty("ScalarAreaPerTimePressure")]
        public TartuGecko ScalarAreaPerTimePressure { get; set; }
    }

    public partial class CardiovascularConfiguration
    {
        [JsonProperty("LeftHeartElastanceMaximum")]
        public Imum LeftHeartElastanceMaximum { get; set; }

        [JsonProperty("LeftHeartElastanceMinimum")]
        public Imum LeftHeartElastanceMinimum { get; set; }

        [JsonProperty("MinimumBloodVolumeFraction")]
        public BeijingPigeon MinimumBloodVolumeFraction { get; set; }

        [JsonProperty("RightHeartElastanceMaximum")]
        public Imum RightHeartElastanceMaximum { get; set; }

        [JsonProperty("RightHeartElastanceMinimum")]
        public Imum RightHeartElastanceMinimum { get; set; }

        [JsonProperty("StandardPulmonaryCapillaryCoverage")]
        public ArakGroundhog StandardPulmonaryCapillaryCoverage { get; set; }
    }

    public partial class Imum
    {
        [JsonProperty("ScalarFlowElastance")]
        public TartuGecko ScalarFlowElastance { get; set; }
    }

    public partial class CircuitConfiguration
    {
        [JsonProperty("CardiovascularOpenResistance")]
        public PulmonaryVascularResistance CardiovascularOpenResistance { get; set; }

        [JsonProperty("DefaultClosedElectricResistance")]
        public DefaultElectricResistance DefaultClosedElectricResistance { get; set; }

        [JsonProperty("DefaultOpenElectricResistance")]
        public DefaultElectricResistance DefaultOpenElectricResistance { get; set; }

        [JsonProperty("DefaultClosedFlowResistance")]
        public PulmonaryVascularResistance DefaultClosedFlowResistance { get; set; }

        [JsonProperty("DefaultOpenFlowResistance")]
        public PulmonaryVascularResistance DefaultOpenFlowResistance { get; set; }

        [JsonProperty("DefaultClosedHeatResistance")]
        public DefaultClosedHeatResistance DefaultClosedHeatResistance { get; set; }

        [JsonProperty("DefaultOpenHeatResistance")]
        public DefaultClosedHeatResistance DefaultOpenHeatResistance { get; set; }

        [JsonProperty("MachineClosedResistance")]
        public PulmonaryVascularResistance MachineClosedResistance { get; set; }

        [JsonProperty("MachineOpenResistance")]
        public PulmonaryVascularResistance MachineOpenResistance { get; set; }

        [JsonProperty("RespiratoryClosedResistance")]
        public PulmonaryVascularResistance RespiratoryClosedResistance { get; set; }

        [JsonProperty("RespiratoryOpenResistance")]
        public PulmonaryVascularResistance RespiratoryOpenResistance { get; set; }
    }

    public partial class DefaultElectricResistance
    {
        [JsonProperty("ScalarElectricResistance")]
        public TartuGecko ScalarElectricResistance { get; set; }
    }

    public partial class ConstantsConfiguration
    {
        [JsonProperty("OxygenMetabolicConstant")]
        public ArakGroundhog OxygenMetabolicConstant { get; set; }

        [JsonProperty("StefanBoltzmann")]
        public StefanBoltzmann StefanBoltzmann { get; set; }

        [JsonProperty("UniversalGasConstant")]
        public UniversalGasConstant UniversalGasConstant { get; set; }
    }

    public partial class StefanBoltzmann
    {
        [JsonProperty("ScalarPowerPerAreaTemperatureToTheFourth")]
        public TartuGecko ScalarPowerPerAreaTemperatureToTheFourth { get; set; }
    }

    public partial class UniversalGasConstant
    {
        [JsonProperty("ScalarHeatCapacitancePerAmount")]
        public TartuGecko ScalarHeatCapacitancePerAmount { get; set; }
    }

    public partial class DrugsConfiguration
    {
        [JsonProperty("PDModel")]
        public string PdModel { get; set; }
    }

    public partial class DynamicStabilization
    {
        [JsonProperty("TrackingStabilization")]
        public string TrackingStabilization { get; set; }

        [JsonProperty("RestingConvergence")]
        public FeedbackConvergence RestingConvergence { get; set; }

        [JsonProperty("FeedbackConvergence")]
        public FeedbackConvergence FeedbackConvergence { get; set; }

        [JsonProperty("ConditionConvergence")]
        public ConditionConvergence ConditionConvergence { get; set; }
    }

    public partial class ConditionConvergence
    {
        [JsonProperty("ChronicVentricularSystolicDysfunction")]
        public FeedbackConvergence ChronicVentricularSystolicDysfunction { get; set; }

        [JsonProperty("ChronicAnemia")]
        public FeedbackConvergence ChronicAnemia { get; set; }

        [JsonProperty("LobarPneumonia")]
        public FeedbackConvergence LobarPneumonia { get; set; }

        [JsonProperty("ChronicRenalStenosis")]
        public FeedbackConvergence ChronicRenalStenosis { get; set; }

        [JsonProperty("ChronicObstructivePulmonaryDisease")]
        public FeedbackConvergence ChronicObstructivePulmonaryDisease { get; set; }

        [JsonProperty("ChronicPericardialEffusion")]
        public FeedbackConvergence ChronicPericardialEffusion { get; set; }

        [JsonProperty("ImpairedAlveolarExchange")]
        public FeedbackConvergence ImpairedAlveolarExchange { get; set; }

        [JsonProperty("ConsumeMeal")]
        public FeedbackConvergence ConsumeMeal { get; set; }

        [JsonProperty("InitialEnvironment")]
        public FeedbackConvergence InitialEnvironment { get; set; }
    }

    public partial class FeedbackConvergence
    {
        [JsonProperty("ConvergenceTime")]
        public TimeStep ConvergenceTime { get; set; }

        [JsonProperty("MinimumReactionTime")]
        public TimeStep MinimumReactionTime { get; set; }

        [JsonProperty("MaximumAllowedStabilizationTime")]
        public TimeStep MaximumAllowedStabilizationTime { get; set; }

        [JsonProperty("PropertyConvergence")]
        public List<PropertyConvergence> PropertyConvergence { get; set; }
    }

    public partial class PropertyConvergence
    {
        [JsonProperty("DataRequest")]
        public DataRequest DataRequest { get; set; }

        [JsonProperty("PercentDifference")]
        public double PercentDifference { get; set; }
    }

    public partial class DataRequest
    {
        [JsonProperty("DecimalFormat")]
        public ActiveActions DecimalFormat { get; set; }

        [JsonProperty("Category")]
        public Category Category { get; set; }

        [JsonProperty("PropertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("Unit", NullValueHandling = NullValueHandling.Ignore)]
        public Unit? Unit { get; set; }
    }

    public partial class EnergyConfiguration
    {
        [JsonProperty("BodySpecificHeat")]
        public SpecificHeat BodySpecificHeat { get; set; }

        [JsonProperty("CarbonDioxideProductionFromOxygenConsumptionConstant")]
        public ArakGroundhog CarbonDioxideProductionFromOxygenConsumptionConstant { get; set; }

        [JsonProperty("CoreTemperatureLow")]
        public CoreTemperatureHigh CoreTemperatureLow { get; set; }

        [JsonProperty("CoreTemperatureHigh")]
        public CoreTemperatureHigh CoreTemperatureHigh { get; set; }

        [JsonProperty("DeltaCoreTemperatureLow")]
        public CoreTemperatureHigh DeltaCoreTemperatureLow { get; set; }

        [JsonProperty("EnergyPerATP")]
        public EnergyPerAtp EnergyPerAtp { get; set; }

        [JsonProperty("SweatHeatTransfer")]
        public SweatHeatTransfer SweatHeatTransfer { get; set; }

        [JsonProperty("VaporizationEnergy")]
        public VaporizationEnergy VaporizationEnergy { get; set; }

        [JsonProperty("VaporSpecificHeat")]
        public SpecificHeat VaporSpecificHeat { get; set; }
    }

    public partial class EnergyPerAtp
    {
        [JsonProperty("ScalarEnergyPerAmount")]
        public TartuGecko ScalarEnergyPerAmount { get; set; }
    }

    public partial class SweatHeatTransfer
    {
        [JsonProperty("ScalarHeatConductance")]
        public TartuGecko ScalarHeatConductance { get; set; }
    }

    public partial class VaporizationEnergy
    {
        [JsonProperty("ScalarEnergyPerMass")]
        public TartuGecko ScalarEnergyPerMass { get; set; }
    }

    public partial class EnvironmentConfiguration
    {
        [JsonProperty("InitialConditions")]
        public Conditions InitialConditions { get; set; }

        [JsonProperty("AirDensity")]
        public BodyDensity AirDensity { get; set; }

        [JsonProperty("AirSpecificHeat")]
        public SpecificHeat AirSpecificHeat { get; set; }

        [JsonProperty("MolarMassOfDryAir")]
        public MolarMass MolarMassOfDryAir { get; set; }

        [JsonProperty("MolarMassOfWaterVapor")]
        public MolarMass MolarMassOfWaterVapor { get; set; }

        [JsonProperty("WaterDensity")]
        public BodyDensity WaterDensity { get; set; }
    }

    public partial class Conditions
    {
        [JsonProperty("SurroundingType")]
        public string SurroundingType { get; set; }

        [JsonProperty("AirVelocity")]
        public AirVelocity AirVelocity { get; set; }

        [JsonProperty("AmbientTemperature")]
        public CoreTemperatureHigh AmbientTemperature { get; set; }

        [JsonProperty("AtmosphericPressure")]
        public TrapaniSnowLeopard AtmosphericPressure { get; set; }

        [JsonProperty("ClothingResistance")]
        public ClothingResistance ClothingResistance { get; set; }

        [JsonProperty("Emissivity")]
        public BeijingPigeon Emissivity { get; set; }

        [JsonProperty("MeanRadiantTemperature")]
        public CoreTemperatureHigh MeanRadiantTemperature { get; set; }

        [JsonProperty("RelativeHumidity")]
        public BeijingPigeon RelativeHumidity { get; set; }

        [JsonProperty("RespirationAmbientTemperature")]
        public CoreTemperatureHigh RespirationAmbientTemperature { get; set; }

        [JsonProperty("AmbientGas")]
        public List<AmbientGas> AmbientGas { get; set; }

        [JsonProperty("AirDensity", NullValueHandling = NullValueHandling.Ignore)]
        public BodyDensity AirDensity { get; set; }
    }

    public partial class AirVelocity
    {
        [JsonProperty("ScalarLengthPerTime")]
        public TartuGecko ScalarLengthPerTime { get; set; }
    }

    public partial class AmbientGas
    {
        [JsonProperty("Name")]
        public Name Name { get; set; }

        [JsonProperty("Amount")]
        public BeijingPigeon Amount { get; set; }
    }

    public partial class ClothingResistance
    {
        [JsonProperty("ScalarHeatResistanceArea")]
        public TartuGecko ScalarHeatResistanceArea { get; set; }
    }

    public partial class GastrointestinalConfiguration
    {
        [JsonProperty("InitialStomachContents")]
        public StomachContents InitialStomachContents { get; set; }

        [JsonProperty("CalciumAbsorptionFraction")]
        public BeijingPigeon CalciumAbsorptionFraction { get; set; }

        [JsonProperty("CalciumDigestionRate")]
        public TionRate CalciumDigestionRate { get; set; }

        [JsonProperty("CarbohydrateAbsorptionFraction")]
        public BeijingPigeon CarbohydrateAbsorptionFraction { get; set; }

        [JsonProperty("DefaultCarbohydrateDigestionRate")]
        public TionRate DefaultCarbohydrateDigestionRate { get; set; }

        [JsonProperty("DefaultFatDigestionRate")]
        public TionRate DefaultFatDigestionRate { get; set; }

        [JsonProperty("DefaultProteinDigestionRate")]
        public TionRate DefaultProteinDigestionRate { get; set; }

        [JsonProperty("FatAbsorptionFraction")]
        public BeijingPigeon FatAbsorptionFraction { get; set; }

        [JsonProperty("ProteinToUreaFraction")]
        public BeijingPigeon ProteinToUreaFraction { get; set; }

        [JsonProperty("WaterDigestionRate")]
        public PuneHedgehog WaterDigestionRate { get; set; }
    }

    public partial class StomachContents
    {
        [JsonProperty("Carbohydrate")]
        public LeanBodyMass Carbohydrate { get; set; }

        [JsonProperty("CarbohydrateDigestionRate")]
        public TionRate CarbohydrateDigestionRate { get; set; }

        [JsonProperty("Fat")]
        public LeanBodyMass Fat { get; set; }

        [JsonProperty("FatDigestionRate")]
        public TionRate FatDigestionRate { get; set; }

        [JsonProperty("Protein")]
        public LeanBodyMass Protein { get; set; }

        [JsonProperty("ProteinDigestionRate")]
        public TionRate ProteinDigestionRate { get; set; }

        [JsonProperty("Calcium")]
        public LeanBodyMass Calcium { get; set; }

        [JsonProperty("Sodium")]
        public LeanBodyMass Sodium { get; set; }

        [JsonProperty("Water")]
        public ChiangMaiGoose Water { get; set; }
    }

    public partial class NervousConfiguration
    {
        [JsonProperty("PupilDiameterBaseline")]
        public Height PupilDiameterBaseline { get; set; }
    }

    public partial class RenalConfiguration
    {
        [JsonProperty("EnableRenal")]
        public string EnableRenal { get; set; }

        [JsonProperty("PlasmaSodiumConcentrationSetPoint")]
        public BodyDensity PlasmaSodiumConcentrationSetPoint { get; set; }

        [JsonProperty("LeftGlomerularFilteringSurfaceAreaBaseline")]
        public AlveoliSurfaceArea LeftGlomerularFilteringSurfaceAreaBaseline { get; set; }

        [JsonProperty("LeftGlomerularFluidPermeabilityBaseline")]
        public LeftGlomerularFluidPermeabilityBaseline LeftGlomerularFluidPermeabilityBaseline { get; set; }

        [JsonProperty("LeftTubularReabsorptionFilteringSurfaceAreaBaseline")]
        public AlveoliSurfaceArea LeftTubularReabsorptionFilteringSurfaceAreaBaseline { get; set; }

        [JsonProperty("LeftTubularReabsorptionFluidPermeabilityBaseline")]
        public LeftGlomerularFluidPermeabilityBaseline LeftTubularReabsorptionFluidPermeabilityBaseline { get; set; }

        [JsonProperty("MaximumAfferentResistance")]
        public PulmonaryVascularResistance MaximumAfferentResistance { get; set; }

        [JsonProperty("MinimumAfferentResistance")]
        public PulmonaryVascularResistance MinimumAfferentResistance { get; set; }

        [JsonProperty("RightGlomerularFilteringSurfaceAreaBaseline")]
        public AlveoliSurfaceArea RightGlomerularFilteringSurfaceAreaBaseline { get; set; }

        [JsonProperty("RightGlomerularFluidPermeabilityBaseline")]
        public LeftGlomerularFluidPermeabilityBaseline RightGlomerularFluidPermeabilityBaseline { get; set; }

        [JsonProperty("RightTubularReabsorptionFilteringSurfaceAreaBaseline")]
        public AlveoliSurfaceArea RightTubularReabsorptionFilteringSurfaceAreaBaseline { get; set; }

        [JsonProperty("RightTubularReabsorptionFluidPermeabilityBaseline")]
        public LeftGlomerularFluidPermeabilityBaseline RightTubularReabsorptionFluidPermeabilityBaseline { get; set; }
    }

    public partial class AlveoliSurfaceArea
    {
        [JsonProperty("ScalarArea")]
        public TartuGecko ScalarArea { get; set; }
    }

    public partial class LeftGlomerularFluidPermeabilityBaseline
    {
        [JsonProperty("ScalarVolumePerTimePressureArea")]
        public TartuGecko ScalarVolumePerTimePressureArea { get; set; }
    }

    public partial class RespiratoryConfiguration
    {
        [JsonProperty("CentralControllerCO2PressureSetPoint")]
        public TrapaniSnowLeopard CentralControllerCo2PressureSetPoint { get; set; }

        [JsonProperty("CentralVentilatoryControllerGain")]
        public ArakGroundhog CentralVentilatoryControllerGain { get; set; }

        [JsonProperty("PeripheralControllerCO2PressureSetPoint")]
        public TrapaniSnowLeopard PeripheralControllerCo2PressureSetPoint { get; set; }

        [JsonProperty("PeripheralVentilatoryControllerGain")]
        public ArakGroundhog PeripheralVentilatoryControllerGain { get; set; }

        [JsonProperty("PleuralComplianceSensitivity")]
        public PleuralComplianceSensitivity PleuralComplianceSensitivity { get; set; }

        [JsonProperty("PulmonaryVentilationRateMaximum")]
        public PuneHedgehog PulmonaryVentilationRateMaximum { get; set; }

        [JsonProperty("VentilationTidalVolumeIntercept")]
        public ChiangMaiGoose VentilationTidalVolumeIntercept { get; set; }

        [JsonProperty("VentilatoryOcclusionPressure")]
        public TrapaniSnowLeopard VentilatoryOcclusionPressure { get; set; }

        [JsonProperty("MinimumAllowableTidalVolume")]
        public ChiangMaiGoose MinimumAllowableTidalVolume { get; set; }

        [JsonProperty("MinimumAllowableInpiratoryAndExpiratoryPeriod")]
        public TimeStep MinimumAllowableInpiratoryAndExpiratoryPeriod { get; set; }
    }

    public partial class PleuralComplianceSensitivity
    {
        [JsonProperty("ScalarInverseVolume")]
        public TartuGecko ScalarInverseVolume { get; set; }
    }

    public partial class TissueConfiguration
    {
        [JsonProperty("EnableTissue")]
        public string EnableTissue { get; set; }
    }

    public partial class Drug
    {
        [JsonProperty("Common")]
        public DrugCommon Common { get; set; }
    }

    public partial class DrugCommon
    {
        [JsonProperty("BronchodilationLevel")]
        public BronchodilationLevel BronchodilationLevel { get; set; }

        [JsonProperty("HeartRateChange")]
        public HeartRateBaseline HeartRateChange { get; set; }

        [JsonProperty("MeanBloodPressureChange")]
        public TrapaniSnowLeopard MeanBloodPressureChange { get; set; }

        [JsonProperty("NeuromuscularBlockLevel")]
        public CarbonMonoxideSaturation NeuromuscularBlockLevel { get; set; }

        [JsonProperty("PulsePressureChange")]
        public TrapaniSnowLeopard PulsePressureChange { get; set; }

        [JsonProperty("PupillaryResponse")]
        public PupillaryResponse PupillaryResponse { get; set; }

        [JsonProperty("RespirationRateChange")]
        public RespirationRateChange RespirationRateChange { get; set; }

        [JsonProperty("SedationLevel")]
        public CarbonMonoxideSaturation SedationLevel { get; set; }

        [JsonProperty("TidalVolumeChange")]
        public TidalVolumeChange TidalVolumeChange { get; set; }

        [JsonProperty("TubularPermeabilityChange")]
        public TubularPermeabilityChange TubularPermeabilityChange { get; set; }
    }

    public partial class RespirationRateChange
    {
        [JsonProperty("ScalarFrequency")]
        public ScalarTimeClass ScalarFrequency { get; set; }
    }

    public partial class TidalVolumeChange
    {
        [JsonProperty("ScalarVolume")]
        public ScalarTimeClass ScalarVolume { get; set; }
    }

    public partial class ElectroCardioGram
    {
        [JsonProperty("Common")]
        public ElectroCardioGramCommon Common { get; set; }

        [JsonProperty("HeartRythmTimeS")]
        public double HeartRythmTimeS { get; set; }

        [JsonProperty("HeartRythmPeriodS")]
        public double HeartRythmPeriodS { get; set; }

        [JsonProperty("Waveforms")]
        public Waveforms Waveforms { get; set; }
    }

    public partial class ElectroCardioGramCommon
    {
        [JsonProperty("Lead3ElectricPotential")]
        public Lead3ElectricPotential Lead3ElectricPotential { get; set; }
    }

    public partial class Lead3ElectricPotential
    {
        [JsonProperty("ScalarElectricPotential")]
        public TartuGecko ScalarElectricPotential { get; set; }
    }

    public partial class Waveforms
    {
        [JsonProperty("Waveform")]
        public List<Waveform> Waveform { get; set; }
    }

    public partial class Waveform
    {
        [JsonProperty("Lead")]
        public string Lead { get; set; }

        [JsonProperty("Data")]
        public Data Data { get; set; }

        [JsonProperty("TimeStep")]
        public TimeStep TimeStep { get; set; }

        [JsonProperty("ActiveIndicies")]
        public List<long> ActiveIndicies { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("FunctionElectricPotentialVsTime")]
        public FunctionElectricPotentialVsTime FunctionElectricPotentialVsTime { get; set; }
    }

    public partial class FunctionElectricPotentialVsTime
    {
        [JsonProperty("Dependent")]
        public Dependent Dependent { get; set; }

        [JsonProperty("Independent")]
        public Dependent Independent { get; set; }

        [JsonProperty("DependentUnit")]
        public Unit DependentUnit { get; set; }

        [JsonProperty("IndependentUnit")]
        public Unit IndependentUnit { get; set; }
    }

    public partial class Dependent
    {
        [JsonProperty("Value")]
        public List<double> Value { get; set; }
    }

    public partial class Endocrine
    {
        [JsonProperty("Common")]
        public EndocrineCommon Common { get; set; }
    }

    public partial class EndocrineCommon
    {
        [JsonProperty("InsulinSynthesisRate")]
        public Rate InsulinSynthesisRate { get; set; }
    }

    public partial class Rate
    {
        [JsonProperty("ScalarAmountPerTime")]
        public TartuGecko ScalarAmountPerTime { get; set; }
    }

    public partial class Energy
    {
        [JsonProperty("Common")]
        public EnergyCommon Common { get; set; }

        [JsonProperty("EnduranceEnergyStoreJ")]
        public long EnduranceEnergyStoreJ { get; set; }

        [JsonProperty("MediumPowerEnergyStoreJ")]
        public long MediumPowerEnergyStoreJ { get; set; }

        [JsonProperty("PeakPowerEnergyStoreJ")]
        public long PeakPowerEnergyStoreJ { get; set; }

        [JsonProperty("UsableEnergyStoreJ")]
        public long UsableEnergyStoreJ { get; set; }

        [JsonProperty("BloodpH")]
        public EsbjergCougar BloodpH { get; set; }

        [JsonProperty("BicarbonateMolarityMmolPerL")]
        public EsbjergCougar BicarbonateMolarityMmolPerL { get; set; }
    }

    public partial class EnergyCommon
    {
        [JsonProperty("CoreTemperature")]
        public CoreTemperatureHigh CoreTemperature { get; set; }

        [JsonProperty("CreatinineProductionRate")]
        public Rate CreatinineProductionRate { get; set; }

        [JsonProperty("ExerciseMeanArterialPressureDelta")]
        public ExerciseMeanArterialPressureDelta ExerciseMeanArterialPressureDelta { get; set; }

        [JsonProperty("FatigueLevel")]
        public CarbonMonoxideSaturation FatigueLevel { get; set; }

        [JsonProperty("KetoneProductionRate")]
        public Rate KetoneProductionRate { get; set; }

        [JsonProperty("LactateProductionRate")]
        public Rate LactateProductionRate { get; set; }

        [JsonProperty("SkinTemperature")]
        public CoreTemperatureHigh SkinTemperature { get; set; }

        [JsonProperty("SweatRate")]
        public SweatRate SweatRate { get; set; }

        [JsonProperty("TotalMetabolicRate")]
        public BasalMetabolicRate TotalMetabolicRate { get; set; }

        [JsonProperty("TotalWorkRateLevel")]
        public CarbonMonoxideSaturation TotalWorkRateLevel { get; set; }
    }

    public partial class ExerciseMeanArterialPressureDelta
    {
        [JsonProperty("ScalarPressure")]
        public ScalarTimeClass ScalarPressure { get; set; }
    }

    public partial class SweatRate
    {
        [JsonProperty("ScalarMassPerTime")]
        public ScalarTimeClass ScalarMassPerTime { get; set; }
    }

    public partial class Environment
    {
        [JsonProperty("Common")]
        public EnvironmentCommon Common { get; set; }

        [JsonProperty("PatientEquivalentDiameterM")]
        public double PatientEquivalentDiameterM { get; set; }
    }

    public partial class EnvironmentCommon
    {
        [JsonProperty("Conditions")]
        public Conditions Conditions { get; set; }

        [JsonProperty("ConvectiveHeatLoss")]
        public BasalMetabolicRate ConvectiveHeatLoss { get; set; }

        [JsonProperty("ConvectiveHeatTranferCoefficient")]
        public TiveHeatTranferCoefficient ConvectiveHeatTranferCoefficient { get; set; }

        [JsonProperty("EvaporativeHeatLoss")]
        public BasalMetabolicRate EvaporativeHeatLoss { get; set; }

        [JsonProperty("EvaporativeHeatTranferCoefficient")]
        public TiveHeatTranferCoefficient EvaporativeHeatTranferCoefficient { get; set; }

        [JsonProperty("RadiativeHeatLoss")]
        public BasalMetabolicRate RadiativeHeatLoss { get; set; }

        [JsonProperty("RadiativeHeatTranferCoefficient")]
        public TiveHeatTranferCoefficient RadiativeHeatTranferCoefficient { get; set; }

        [JsonProperty("RespirationHeatLoss")]
        public BasalMetabolicRate RespirationHeatLoss { get; set; }

        [JsonProperty("SkinHeatLoss")]
        public BasalMetabolicRate SkinHeatLoss { get; set; }
    }

    public partial class TiveHeatTranferCoefficient
    {
        [JsonProperty("ScalarHeatConductancePerArea")]
        public TartuGecko ScalarHeatConductancePerArea { get; set; }
    }

    public partial class Gastrointestinal
    {
        [JsonProperty("Common")]
        public GastrointestinalCommon Common { get; set; }
    }

    public partial class GastrointestinalCommon
    {
        [JsonProperty("ChymeAbsorptionRate")]
        public PuneHedgehog ChymeAbsorptionRate { get; set; }

        [JsonProperty("StomachContents")]
        public StomachContents StomachContents { get; set; }
    }

    public partial class Hepatic
    {
        [JsonProperty("Common")]
        public ActiveActions Common { get; set; }
    }

    public partial class Inhaler
    {
        [JsonProperty("Common")]
        public InhalerCommon Common { get; set; }
    }

    public partial class InhalerCommon
    {
        [JsonProperty("State")]
        public string State { get; set; }
    }

    public partial class Nervous
    {
        [JsonProperty("Common")]
        public NervousCommon Common { get; set; }

        [JsonProperty("ArterialOxygenSetPointMmHg")]
        public double ArterialOxygenSetPointMmHg { get; set; }

        [JsonProperty("ArterialCarbonDioxideSetPointMmHg")]
        public double ArterialCarbonDioxideSetPointMmHg { get; set; }
    }

    public partial class NervousCommon
    {
        [JsonProperty("BaroreceptorHeartRateScale")]
        public ArakGroundhog BaroreceptorHeartRateScale { get; set; }

        [JsonProperty("BaroreceptorHeartElastanceScale")]
        public ArakGroundhog BaroreceptorHeartElastanceScale { get; set; }

        [JsonProperty("BaroreceptorResistanceScale")]
        public ArakGroundhog BaroreceptorResistanceScale { get; set; }

        [JsonProperty("BaroreceptorComplianceScale")]
        public ArakGroundhog BaroreceptorComplianceScale { get; set; }

        [JsonProperty("LeftEyePupillaryResponse")]
        public TEyePupillaryResponse LeftEyePupillaryResponse { get; set; }

        [JsonProperty("RightEyePupillaryResponse")]
        public TEyePupillaryResponse RightEyePupillaryResponse { get; set; }

        [JsonProperty("ChemoreceptorHeartRateScale")]
        public ArakGroundhog ChemoreceptorHeartRateScale { get; set; }

        [JsonProperty("ChemoreceptorHeartElastanceScale")]
        public ArakGroundhog ChemoreceptorHeartElastanceScale { get; set; }
    }

    public partial class TEyePupillaryResponse
    {
        [JsonProperty("ReactivityModifier")]
        public TubularPermeabilityChange ReactivityModifier { get; set; }

        [JsonProperty("ShapeModifier")]
        public TubularPermeabilityChange ShapeModifier { get; set; }

        [JsonProperty("SizeModifier")]
        public BronchodilationLevel SizeModifier { get; set; }
    }

    public partial class Patient
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Age")]
        public TimeStep Age { get; set; }

        [JsonProperty("Weight")]
        public LeanBodyMass Weight { get; set; }

        [JsonProperty("Height")]
        public Height Height { get; set; }

        [JsonProperty("BodyDensity")]
        public BodyDensity BodyDensity { get; set; }

        [JsonProperty("BodyFatFraction")]
        public BeijingPigeon BodyFatFraction { get; set; }

        [JsonProperty("LeanBodyMass")]
        public LeanBodyMass LeanBodyMass { get; set; }

        [JsonProperty("AlveoliSurfaceArea")]
        public AlveoliSurfaceArea AlveoliSurfaceArea { get; set; }

        [JsonProperty("RightLungRatio")]
        public BeijingPigeon RightLungRatio { get; set; }

        [JsonProperty("SkinSurfaceArea")]
        public AlveoliSurfaceArea SkinSurfaceArea { get; set; }

        [JsonProperty("BasalMetabolicRate")]
        public BasalMetabolicRate BasalMetabolicRate { get; set; }

        [JsonProperty("BloodVolumeBaseline")]
        public ChiangMaiGoose BloodVolumeBaseline { get; set; }

        [JsonProperty("DiastolicArterialPressureBaseline")]
        public TrapaniSnowLeopard DiastolicArterialPressureBaseline { get; set; }

        [JsonProperty("HeartRateBaseline")]
        public HeartRateBaseline HeartRateBaseline { get; set; }

        [JsonProperty("MeanArterialPressureBaseline")]
        public TrapaniSnowLeopard MeanArterialPressureBaseline { get; set; }

        [JsonProperty("RespirationRateBaseline")]
        public HeartRateBaseline RespirationRateBaseline { get; set; }

        [JsonProperty("SystolicArterialPressureBaseline")]
        public TrapaniSnowLeopard SystolicArterialPressureBaseline { get; set; }

        [JsonProperty("TidalVolumeBaseline")]
        public ChiangMaiGoose TidalVolumeBaseline { get; set; }

        [JsonProperty("HeartRateMaximum")]
        public HeartRateBaseline HeartRateMaximum { get; set; }

        [JsonProperty("HeartRateMinimum")]
        public HeartRateBaseline HeartRateMinimum { get; set; }

        [JsonProperty("ExpiratoryReserveVolume")]
        public ChiangMaiGoose ExpiratoryReserveVolume { get; set; }

        [JsonProperty("FunctionalResidualCapacity")]
        public ChiangMaiGoose FunctionalResidualCapacity { get; set; }

        [JsonProperty("InspiratoryCapacity")]
        public ChiangMaiGoose InspiratoryCapacity { get; set; }

        [JsonProperty("InspiratoryReserveVolume")]
        public ChiangMaiGoose InspiratoryReserveVolume { get; set; }

        [JsonProperty("ResidualVolume")]
        public ChiangMaiGoose ResidualVolume { get; set; }

        [JsonProperty("TotalLungCapacity")]
        public ChiangMaiGoose TotalLungCapacity { get; set; }

        [JsonProperty("VitalCapacity")]
        public ChiangMaiGoose VitalCapacity { get; set; }

        [JsonProperty("ActiveEvent")]
        public List<ActiveEvent> ActiveEvent { get; set; }
    }

    public partial class ActiveEvent
    {
        [JsonProperty("Event")]
        public string Event { get; set; }

        [JsonProperty("Duration")]
        public TimeStep Duration { get; set; }
    }

    public partial class Renal
    {
        [JsonProperty("Common")]
        public RenalCommon Common { get; set; }

        [JsonProperty("LeftAfferentResistanceMmHgSPerML")]
        public double LeftAfferentResistanceMmHgSPerMl { get; set; }

        [JsonProperty("RightAfferentResistanceMmHgSPerML")]
        public double RightAfferentResistanceMmHgSPerMl { get; set; }

        [JsonProperty("LeftSodiumFlowSetPointMgPerS")]
        public double LeftSodiumFlowSetPointMgPerS { get; set; }

        [JsonProperty("RightSodiumFlowSetPointMgPerS")]
        public double RightSodiumFlowSetPointMgPerS { get; set; }

        [JsonProperty("UrineProductionRateMLPerMin")]
        public EsbjergCougar UrineProductionRateMlPerMin { get; set; }

        [JsonProperty("UrineOsmolarityMOsmPerL")]
        public EsbjergCougar UrineOsmolarityMOsmPerL { get; set; }

        [JsonProperty("SodiumConcentrationMgPerML")]
        public EsbjergCougar SodiumConcentrationMgPerMl { get; set; }

        [JsonProperty("SodiumExcretionRateMgPerMin")]
        public EsbjergCougar SodiumExcretionRateMgPerMin { get; set; }

        [JsonProperty("LeftSodiumFlowMgPerS")]
        public EsbjergCougar LeftSodiumFlowMgPerS { get; set; }

        [JsonProperty("RightSodiumFlowMgPerS")]
        public EsbjergCougar RightSodiumFlowMgPerS { get; set; }

        [JsonProperty("LeftRenalArterialPressureMmHg")]
        public EsbjergCougar LeftRenalArterialPressureMmHg { get; set; }

        [JsonProperty("RightRenalArterialPressureMmHg")]
        public EsbjergCougar RightRenalArterialPressureMmHg { get; set; }
    }

    public partial class RenalCommon
    {
        [JsonProperty("FiltrationFraction")]
        public BeijingPigeon FiltrationFraction { get; set; }

        [JsonProperty("GlomerularFiltrationRate")]
        public PuneHedgehog GlomerularFiltrationRate { get; set; }

        [JsonProperty("LeftAfferentArterioleResistance")]
        public PulmonaryVascularResistance LeftAfferentArterioleResistance { get; set; }

        [JsonProperty("LeftBowmansCapsulesHydrostaticPressure")]
        public TrapaniSnowLeopard LeftBowmansCapsulesHydrostaticPressure { get; set; }

        [JsonProperty("LeftBowmansCapsulesOsmoticPressure")]
        public ExerciseMeanArterialPressureDelta LeftBowmansCapsulesOsmoticPressure { get; set; }

        [JsonProperty("LeftEfferentArterioleResistance")]
        public PulmonaryVascularResistance LeftEfferentArterioleResistance { get; set; }

        [JsonProperty("LeftGlomerularCapillariesHydrostaticPressure")]
        public TrapaniSnowLeopard LeftGlomerularCapillariesHydrostaticPressure { get; set; }

        [JsonProperty("LeftGlomerularCapillariesOsmoticPressure")]
        public TrapaniSnowLeopard LeftGlomerularCapillariesOsmoticPressure { get; set; }

        [JsonProperty("LeftGlomerularFiltrationCoefficient")]
        public DiffusingCapacity LeftGlomerularFiltrationCoefficient { get; set; }

        [JsonProperty("LeftGlomerularFiltrationRate")]
        public PuneHedgehog LeftGlomerularFiltrationRate { get; set; }

        [JsonProperty("LeftGlomerularFiltrationSurfaceArea")]
        public AlveoliSurfaceArea LeftGlomerularFiltrationSurfaceArea { get; set; }

        [JsonProperty("LeftGlomerularFluidPermeability")]
        public LeftGlomerularFluidPermeabilityBaseline LeftGlomerularFluidPermeability { get; set; }

        [JsonProperty("LeftFiltrationFraction")]
        public BeijingPigeon LeftFiltrationFraction { get; set; }

        [JsonProperty("LeftNetFiltrationPressure")]
        public TrapaniSnowLeopard LeftNetFiltrationPressure { get; set; }

        [JsonProperty("LeftNetReabsorptionPressure")]
        public TrapaniSnowLeopard LeftNetReabsorptionPressure { get; set; }

        [JsonProperty("LeftPeritubularCapillariesHydrostaticPressure")]
        public TrapaniSnowLeopard LeftPeritubularCapillariesHydrostaticPressure { get; set; }

        [JsonProperty("LeftPeritubularCapillariesOsmoticPressure")]
        public TrapaniSnowLeopard LeftPeritubularCapillariesOsmoticPressure { get; set; }

        [JsonProperty("LeftReabsorptionFiltrationCoefficient")]
        public DiffusingCapacity LeftReabsorptionFiltrationCoefficient { get; set; }

        [JsonProperty("LeftReabsorptionRate")]
        public PuneHedgehog LeftReabsorptionRate { get; set; }

        [JsonProperty("LeftTubularOsmoticPressure")]
        public TrapaniSnowLeopard LeftTubularOsmoticPressure { get; set; }

        [JsonProperty("LeftTubularHydrostaticPressure")]
        public TrapaniSnowLeopard LeftTubularHydrostaticPressure { get; set; }

        [JsonProperty("LeftTubularReabsorptionFiltrationSurfaceArea")]
        public AlveoliSurfaceArea LeftTubularReabsorptionFiltrationSurfaceArea { get; set; }

        [JsonProperty("LeftTubularReabsorptionFluidPermeability")]
        public LeftGlomerularFluidPermeabilityBaseline LeftTubularReabsorptionFluidPermeability { get; set; }

        [JsonProperty("RenalBloodFlow")]
        public PuneHedgehog RenalBloodFlow { get; set; }

        [JsonProperty("RenalPlasmaFlow")]
        public PuneHedgehog RenalPlasmaFlow { get; set; }

        [JsonProperty("RenalVascularResistance")]
        public PulmonaryVascularResistance RenalVascularResistance { get; set; }

        [JsonProperty("RightAfferentArterioleResistance")]
        public PulmonaryVascularResistance RightAfferentArterioleResistance { get; set; }

        [JsonProperty("RightBowmansCapsulesHydrostaticPressure")]
        public TrapaniSnowLeopard RightBowmansCapsulesHydrostaticPressure { get; set; }

        [JsonProperty("RightBowmansCapsulesOsmoticPressure")]
        public ExerciseMeanArterialPressureDelta RightBowmansCapsulesOsmoticPressure { get; set; }

        [JsonProperty("RightEfferentArterioleResistance")]
        public PulmonaryVascularResistance RightEfferentArterioleResistance { get; set; }

        [JsonProperty("RightGlomerularCapillariesHydrostaticPressure")]
        public TrapaniSnowLeopard RightGlomerularCapillariesHydrostaticPressure { get; set; }

        [JsonProperty("RightGlomerularCapillariesOsmoticPressure")]
        public TrapaniSnowLeopard RightGlomerularCapillariesOsmoticPressure { get; set; }

        [JsonProperty("RightGlomerularFiltrationCoefficient")]
        public DiffusingCapacity RightGlomerularFiltrationCoefficient { get; set; }

        [JsonProperty("RightGlomerularFiltrationRate")]
        public PuneHedgehog RightGlomerularFiltrationRate { get; set; }

        [JsonProperty("RightGlomerularFiltrationSurfaceArea")]
        public AlveoliSurfaceArea RightGlomerularFiltrationSurfaceArea { get; set; }

        [JsonProperty("RightGlomerularFluidPermeability")]
        public LeftGlomerularFluidPermeabilityBaseline RightGlomerularFluidPermeability { get; set; }

        [JsonProperty("RightFiltrationFraction")]
        public BeijingPigeon RightFiltrationFraction { get; set; }

        [JsonProperty("RightNetFiltrationPressure")]
        public TrapaniSnowLeopard RightNetFiltrationPressure { get; set; }

        [JsonProperty("RightNetReabsorptionPressure")]
        public TrapaniSnowLeopard RightNetReabsorptionPressure { get; set; }

        [JsonProperty("RightPeritubularCapillariesHydrostaticPressure")]
        public TrapaniSnowLeopard RightPeritubularCapillariesHydrostaticPressure { get; set; }

        [JsonProperty("RightPeritubularCapillariesOsmoticPressure")]
        public TrapaniSnowLeopard RightPeritubularCapillariesOsmoticPressure { get; set; }

        [JsonProperty("RightReabsorptionFiltrationCoefficient")]
        public DiffusingCapacity RightReabsorptionFiltrationCoefficient { get; set; }

        [JsonProperty("RightReabsorptionRate")]
        public PuneHedgehog RightReabsorptionRate { get; set; }

        [JsonProperty("RightTubularOsmoticPressure")]
        public TrapaniSnowLeopard RightTubularOsmoticPressure { get; set; }

        [JsonProperty("RightTubularHydrostaticPressure")]
        public TrapaniSnowLeopard RightTubularHydrostaticPressure { get; set; }

        [JsonProperty("RightTubularReabsorptionFiltrationSurfaceArea")]
        public AlveoliSurfaceArea RightTubularReabsorptionFiltrationSurfaceArea { get; set; }

        [JsonProperty("RightTubularReabsorptionFluidPermeability")]
        public LeftGlomerularFluidPermeabilityBaseline RightTubularReabsorptionFluidPermeability { get; set; }

        [JsonProperty("UrinationRate")]
        public UrinationRate UrinationRate { get; set; }

        [JsonProperty("UrineOsmolality")]
        public UrineOsmolality UrineOsmolality { get; set; }

        [JsonProperty("UrineOsmolarity")]
        public UrineOsmolarity UrineOsmolarity { get; set; }

        [JsonProperty("UrineProductionRate")]
        public PuneHedgehog UrineProductionRate { get; set; }

        [JsonProperty("UrineSpecificGravity")]
        public ArakGroundhog UrineSpecificGravity { get; set; }

        [JsonProperty("UrineVolume")]
        public ChiangMaiGoose UrineVolume { get; set; }

        [JsonProperty("UrineUreaNitrogenConcentration")]
        public BodyDensity UrineUreaNitrogenConcentration { get; set; }
    }

    public partial class UrineOsmolality
    {
        [JsonProperty("ScalarOsmolality")]
        public TartuGecko ScalarOsmolality { get; set; }
    }

    public partial class UrineOsmolarity
    {
        [JsonProperty("ScalarOsmolarity")]
        public TartuGecko ScalarOsmolarity { get; set; }
    }

    public partial class Respiratory
    {
        [JsonProperty("Common")]
        public RespiratoryCommon Common { get; set; }

        [JsonProperty("InitialExpiratoryReserveVolumeL")]
        public double InitialExpiratoryReserveVolumeL { get; set; }

        [JsonProperty("InitialFunctionalResidualCapacityL")]
        public double InitialFunctionalResidualCapacityL { get; set; }

        [JsonProperty("InitialInspiratoryCapacityL")]
        public double InitialInspiratoryCapacityL { get; set; }

        [JsonProperty("InitialResidualVolumeL")]
        public double InitialResidualVolumeL { get; set; }

        [JsonProperty("BreathingCycle")]
        public bool BreathingCycle { get; set; }

        [JsonProperty("TopBreathTotalVolumeL")]
        public double TopBreathTotalVolumeL { get; set; }

        [JsonProperty("TopBreathAlveoliVolumeL")]
        public double TopBreathAlveoliVolumeL { get; set; }

        [JsonProperty("TopBreathDeadSpaceVolumeL")]
        public double TopBreathDeadSpaceVolumeL { get; set; }

        [JsonProperty("TopBreathPleuralPressureCmH2O")]
        public double TopBreathPleuralPressureCmH2O { get; set; }

        [JsonProperty("LastCardiacCycleBloodPH")]
        public double LastCardiacCycleBloodPh { get; set; }

        [JsonProperty("TopCarinaO2")]
        public double TopCarinaO2 { get; set; }

        [JsonProperty("TopBreathElapsedTimeMin")]
        public double TopBreathElapsedTimeMin { get; set; }

        [JsonProperty("BottomBreathElapsedTimeMin")]
        public double BottomBreathElapsedTimeMin { get; set; }

        [JsonProperty("BottomBreathTotalVolumeL")]
        public double BottomBreathTotalVolumeL { get; set; }

        [JsonProperty("BottomBreathAlveoliVolumeL")]
        public double BottomBreathAlveoliVolumeL { get; set; }

        [JsonProperty("BottomBreathDeadSpaceVolumeL")]
        public double BottomBreathDeadSpaceVolumeL { get; set; }

        [JsonProperty("BottomBreathPleuralPressureCmH2O")]
        public double BottomBreathPleuralPressureCmH2O { get; set; }

        [JsonProperty("BloodPHRunningAverage")]
        public EsbjergCougar BloodPhRunningAverage { get; set; }

        [JsonProperty("ArterialO2PartialPressureMmHg")]
        public double ArterialO2PartialPressureMmHg { get; set; }

        [JsonProperty("ArterialCO2PartialPressureMmHg")]
        public double ArterialCo2PartialPressureMmHg { get; set; }

        [JsonProperty("BreathingCycleTimeS")]
        public double BreathingCycleTimeS { get; set; }

        [JsonProperty("DefaultDrivePressureCmH2O")]
        public double DefaultDrivePressureCmH2O { get; set; }

        [JsonProperty("DriverInspirationTimeS")]
        public double DriverInspirationTimeS { get; set; }

        [JsonProperty("DriverPressureCmH2O")]
        public double DriverPressureCmH2O { get; set; }

        [JsonProperty("DriverPressureMinCmH2O")]
        public double DriverPressureMinCmH2O { get; set; }

        [JsonProperty("ElapsedBreathingCycleTimeMin")]
        public double ElapsedBreathingCycleTimeMin { get; set; }

        [JsonProperty("IEscaleFactor")]
        public long IEscaleFactor { get; set; }

        [JsonProperty("InstantaneousFunctionalResidualCapacityL")]
        public double InstantaneousFunctionalResidualCapacityL { get; set; }

        [JsonProperty("MaxDriverPressureCmH2O")]
        public double MaxDriverPressureCmH2O { get; set; }

        [JsonProperty("PeakRespiratoryDrivePressureCmH2O")]
        public double PeakRespiratoryDrivePressureCmH2O { get; set; }

        [JsonProperty("PreviousTargetAlveolarVentilationLPerMin")]
        public double PreviousTargetAlveolarVentilationLPerMin { get; set; }

        [JsonProperty("VentilationFrequencyPerMin")]
        public double VentilationFrequencyPerMin { get; set; }

        [JsonProperty("VentilationToTidalVolumeSlope")]
        public double VentilationToTidalVolumeSlope { get; set; }

        [JsonProperty("ArterialO2RunningAverageMmHg")]
        public EsbjergCougar ArterialO2RunningAverageMmHg { get; set; }

        [JsonProperty("ArterialCO2RunningAverageMmHg")]
        public EsbjergCougar ArterialCo2RunningAverageMmHg { get; set; }

        [JsonProperty("ExpiratoryReserveVolumeFraction")]
        public long ExpiratoryReserveVolumeFraction { get; set; }

        [JsonProperty("InspiratoryCapacityFraction")]
        public long InspiratoryCapacityFraction { get; set; }
    }

    public partial class RespiratoryCommon
    {
        [JsonProperty("AlveolarArterialGradient")]
        public TrapaniSnowLeopard AlveolarArterialGradient { get; set; }

        [JsonProperty("CarricoIndex")]
        public TrapaniSnowLeopard CarricoIndex { get; set; }

        [JsonProperty("EndTidalCarbonDioxideFraction")]
        public BeijingPigeon EndTidalCarbonDioxideFraction { get; set; }

        [JsonProperty("EndTidalCarbonDioxidePressure")]
        public TrapaniSnowLeopard EndTidalCarbonDioxidePressure { get; set; }

        [JsonProperty("ExpiratoryFlow")]
        public PuneHedgehog ExpiratoryFlow { get; set; }

        [JsonProperty("InspiratoryExpiratoryRatio")]
        public ArakGroundhog InspiratoryExpiratoryRatio { get; set; }

        [JsonProperty("InspiratoryFlow")]
        public PuneHedgehog InspiratoryFlow { get; set; }

        [JsonProperty("PulmonaryCompliance")]
        public PulmonaryCompliance PulmonaryCompliance { get; set; }

        [JsonProperty("PulmonaryResistance")]
        public PulmonaryVascularResistance PulmonaryResistance { get; set; }

        [JsonProperty("RespirationDriverPressure")]
        public TrapaniSnowLeopard RespirationDriverPressure { get; set; }

        [JsonProperty("RespirationMusclePressure")]
        public TrapaniSnowLeopard RespirationMusclePressure { get; set; }

        [JsonProperty("RespirationRate")]
        public HeartRateBaseline RespirationRate { get; set; }

        [JsonProperty("SpecificVentilation")]
        public ArakGroundhog SpecificVentilation { get; set; }

        [JsonProperty("TidalVolume")]
        public ChiangMaiGoose TidalVolume { get; set; }

        [JsonProperty("TotalAlveolarVentilation")]
        public PuneHedgehog TotalAlveolarVentilation { get; set; }

        [JsonProperty("TotalDeadSpaceVentilation")]
        public PuneHedgehog TotalDeadSpaceVentilation { get; set; }

        [JsonProperty("TotalLungVolume")]
        public ChiangMaiGoose TotalLungVolume { get; set; }

        [JsonProperty("TotalPulmonaryVentilation")]
        public PuneHedgehog TotalPulmonaryVentilation { get; set; }

        [JsonProperty("TranspulmonaryPressure")]
        public TrapaniSnowLeopard TranspulmonaryPressure { get; set; }
    }

    public partial class SimulationTime
    {
        [JsonProperty("ScalarTime")]
        public ScalarTimeClass ScalarTime { get; set; }
    }

    public partial class Tissue
    {
        [JsonProperty("Common")]
        public TissueCommon Common { get; set; }

        [JsonProperty("RestingTissueGlucoseG")]
        public double RestingTissueGlucoseG { get; set; }

        [JsonProperty("RestingBloodGlucoseGPerL")]
        public double RestingBloodGlucoseGPerL { get; set; }

        [JsonProperty("RestingBloodLipidGPerL")]
        public long RestingBloodLipidGPerL { get; set; }

        [JsonProperty("RestingBloodInsulinGPerL")]
        public double RestingBloodInsulinGPerL { get; set; }

        [JsonProperty("RestingPatientMassKg")]
        public double RestingPatientMassKg { get; set; }

        [JsonProperty("RestingFluidMassKg")]
        public double RestingFluidMassKg { get; set; }
    }

    public partial class TissueCommon
    {
        [JsonProperty("CarbonDioxideProductionRate")]
        public PuneHedgehog CarbonDioxideProductionRate { get; set; }

        [JsonProperty("ExtracellularFluidVolume")]
        public ChiangMaiGoose ExtracellularFluidVolume { get; set; }

        [JsonProperty("ExtravascularFluidVolume")]
        public ChiangMaiGoose ExtravascularFluidVolume { get; set; }

        [JsonProperty("IntracellularFluidPH")]
        public ArakGroundhog IntracellularFluidPh { get; set; }

        [JsonProperty("IntracellularFluidVolume")]
        public ChiangMaiGoose IntracellularFluidVolume { get; set; }

        [JsonProperty("OxygenConsumptionRate")]
        public PuneHedgehog OxygenConsumptionRate { get; set; }

        [JsonProperty("RespiratoryExchangeRatio")]
        public ArakGroundhog RespiratoryExchangeRatio { get; set; }
    }

    public enum Unit { Clo, Cm2MinMmHg, CmH2O, CmH2OSL, CtL, CtUL, DegC, G, GCm2S, GCm3, GL, GM3, GML, GMin, GMol, In, JK, JKKg, JKMol, K, KJKKg, KJKg, KW, KcalDay, KcalKKg, KcalKS, KcalMol, Kg, KgM3, KgMol, KgS, L, LCmH2O, LMin, LS, Lb, M2, ML, MLMin, MLMinKg, MLMinM2, MLMinMmHgM2, MLMmHg, MLS, MLSKg, MLSMmHg, MLSMmHgM2, MOsmKg, MOsmL, MS, MV, Mg, MgG, MgML, MgMin, MgS, Mm, MmHg, MmHgML, MmHgMinML, MmHgMinMLM2, MmHgSML, MmolL, MolDay, Ohm, PaSM3, PgCt, PmolMin, S, The1Atm, The1L, The1Min, UL, Ug, UgML, UmolMin, UmolS, W, WM2K, WM2K4, Yr };

    public enum ChargeInBlood { Negative, Neutral, Positive };

    public enum ValueEnum { Infinity };

    public enum Name { Acetoacetate, Albumin, Bicarbonate, Calcium, Carbaminohemoglobin, CarbonDioxide, Chloride, Creatinine, Epinephrine, Glucose, Hemoglobin, Insulin, Lactate, Nitrogen, OxyCarbaminohemoglobin, Oxygen, Oxyhemoglobin, Potassium, Sodium, Tristearin, Urea };

    public enum State { Gas, Liquid, Molecular };

    public enum PurpleUnit { CmH2O, CmH2OSL, GDL, J, JK, K, KW, LCmH2O, LS, MLMin, MLMmHg, MLS, MgDL, MgL, MgML, MmHg, MmHgSML, MmolL, MmolML, UgL, UgML, W };

    public enum NextPolarizedState { Closed, Open };

    public enum Category { Physiology };

    public partial struct ValueUnion
    {
        public double? Double;
        public ValueEnum? Enum;

        public static implicit operator ValueUnion(double Double) => new ValueUnion { Double = Double };
        public static implicit operator ValueUnion(ValueEnum Enum) => new ValueUnion { Enum = Enum };
    }

    public partial class SimulationData
    {
        public static SimulationData FromJson(string json) => JsonConvert.DeserializeObject<SimulationData>(json, Simulation.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this SimulationData self) => JsonConvert.SerializeObject(self, Simulation.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                UnitConverter.Singleton,
                ChargeInBloodConverter.Singleton,
                ValueUnionConverter.Singleton,
                ValueEnumConverter.Singleton,
                NameConverter.Singleton,
                StateConverter.Singleton,
                PurpleUnitConverter.Singleton,
                NextPolarizedStateConverter.Singleton,
                CategoryConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class UnitConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Unit) || t == typeof(Unit?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "1/L":
                    return Unit.The1L;
                case "1/atm":
                    return Unit.The1Atm;
                case "1/min":
                    return Unit.The1Min;
                case "J/K":
                    return Unit.JK;
                case "J/K kg":
                    return Unit.JKKg;
                case "J/K mol":
                    return Unit.JKMol;
                case "K":
                    return Unit.K;
                case "K/W":
                    return Unit.KW;
                case "L":
                    return Unit.L;
                case "L/cmH2O":
                    return Unit.LCmH2O;
                case "L/min":
                    return Unit.LMin;
                case "L/s":
                    return Unit.LS;
                case "Pa s/m^3":
                    return Unit.PaSM3;
                case "W":
                    return Unit.W;
                case "W/ m^2 K^4":
                    return Unit.WM2K4;
                case "W/m^2 K":
                    return Unit.WM2K;
                case "clo":
                    return Unit.Clo;
                case "cmH2O":
                    return Unit.CmH2O;
                case "cmH2O s/L":
                    return Unit.CmH2OSL;
                case "cm^2/min mmHg":
                    return Unit.Cm2MinMmHg;
                case "ct/L":
                    return Unit.CtL;
                case "ct/uL":
                    return Unit.CtUL;
                case "degC":
                    return Unit.DegC;
                case "g":
                    return Unit.G;
                case "g/L":
                    return Unit.GL;
                case "g/cm^2 s":
                    return Unit.GCm2S;
                case "g/cm^3":
                    return Unit.GCm3;
                case "g/mL":
                    return Unit.GML;
                case "g/m^3":
                    return Unit.GM3;
                case "g/min":
                    return Unit.GMin;
                case "g/mol":
                    return Unit.GMol;
                case "in":
                    return Unit.In;
                case "kJ/K kg":
                    return Unit.KJKKg;
                case "kJ/kg":
                    return Unit.KJKg;
                case "kcal/K kg":
                    return Unit.KcalKKg;
                case "kcal/K s":
                    return Unit.KcalKS;
                case "kcal/day":
                    return Unit.KcalDay;
                case "kcal/mol":
                    return Unit.KcalMol;
                case "kg":
                    return Unit.Kg;
                case "kg/m^3":
                    return Unit.KgM3;
                case "kg/mol":
                    return Unit.KgMol;
                case "kg/s":
                    return Unit.KgS;
                case "lb":
                    return Unit.Lb;
                case "m/s":
                    return Unit.MS;
                case "mL":
                    return Unit.ML;
                case "mL/min":
                    return Unit.MLMin;
                case "mL/min kg":
                    return Unit.MLMinKg;
                case "mL/min m^2":
                    return Unit.MLMinM2;
                case "mL/min mmHg m^2":
                    return Unit.MLMinMmHgM2;
                case "mL/mmHg":
                    return Unit.MLMmHg;
                case "mL/s":
                    return Unit.MLS;
                case "mL/s kg":
                    return Unit.MLSKg;
                case "mL/s mmHg":
                    return Unit.MLSMmHg;
                case "mL/s mmHg m^2":
                    return Unit.MLSMmHgM2;
                case "mOsm/L":
                    return Unit.MOsmL;
                case "mOsm/kg":
                    return Unit.MOsmKg;
                case "mV":
                    return Unit.MV;
                case "m^2":
                    return Unit.M2;
                case "mg":
                    return Unit.Mg;
                case "mg/g":
                    return Unit.MgG;
                case "mg/mL":
                    return Unit.MgML;
                case "mg/min":
                    return Unit.MgMin;
                case "mg/s":
                    return Unit.MgS;
                case "mm":
                    return Unit.Mm;
                case "mmHg":
                    return Unit.MmHg;
                case "mmHg min/mL":
                    return Unit.MmHgMinML;
                case "mmHg min/mL m^2":
                    return Unit.MmHgMinMLM2;
                case "mmHg s/mL":
                    return Unit.MmHgSML;
                case "mmHg/mL":
                    return Unit.MmHgML;
                case "mmol/L":
                    return Unit.MmolL;
                case "mol/day":
                    return Unit.MolDay;
                case "ohm":
                    return Unit.Ohm;
                case "pg/ct":
                    return Unit.PgCt;
                case "pmol/min":
                    return Unit.PmolMin;
                case "s":
                    return Unit.S;
                case "uL":
                    return Unit.UL;
                case "ug":
                    return Unit.Ug;
                case "ug/mL":
                    return Unit.UgML;
                case "umol/min":
                    return Unit.UmolMin;
                case "umol/s":
                    return Unit.UmolS;
                case "yr":
                    return Unit.Yr;
            }
            throw new Exception("Cannot unmarshal type Unit");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Unit)untypedValue;
            switch (value)
            {
                case Unit.The1L:
                    serializer.Serialize(writer, "1/L");
                    return;
                case Unit.The1Atm:
                    serializer.Serialize(writer, "1/atm");
                    return;
                case Unit.The1Min:
                    serializer.Serialize(writer, "1/min");
                    return;
                case Unit.JK:
                    serializer.Serialize(writer, "J/K");
                    return;
                case Unit.JKKg:
                    serializer.Serialize(writer, "J/K kg");
                    return;
                case Unit.JKMol:
                    serializer.Serialize(writer, "J/K mol");
                    return;
                case Unit.K:
                    serializer.Serialize(writer, "K");
                    return;
                case Unit.KW:
                    serializer.Serialize(writer, "K/W");
                    return;
                case Unit.L:
                    serializer.Serialize(writer, "L");
                    return;
                case Unit.LCmH2O:
                    serializer.Serialize(writer, "L/cmH2O");
                    return;
                case Unit.LMin:
                    serializer.Serialize(writer, "L/min");
                    return;
                case Unit.LS:
                    serializer.Serialize(writer, "L/s");
                    return;
                case Unit.PaSM3:
                    serializer.Serialize(writer, "Pa s/m^3");
                    return;
                case Unit.W:
                    serializer.Serialize(writer, "W");
                    return;
                case Unit.WM2K4:
                    serializer.Serialize(writer, "W/ m^2 K^4");
                    return;
                case Unit.WM2K:
                    serializer.Serialize(writer, "W/m^2 K");
                    return;
                case Unit.Clo:
                    serializer.Serialize(writer, "clo");
                    return;
                case Unit.CmH2O:
                    serializer.Serialize(writer, "cmH2O");
                    return;
                case Unit.CmH2OSL:
                    serializer.Serialize(writer, "cmH2O s/L");
                    return;
                case Unit.Cm2MinMmHg:
                    serializer.Serialize(writer, "cm^2/min mmHg");
                    return;
                case Unit.CtL:
                    serializer.Serialize(writer, "ct/L");
                    return;
                case Unit.CtUL:
                    serializer.Serialize(writer, "ct/uL");
                    return;
                case Unit.DegC:
                    serializer.Serialize(writer, "degC");
                    return;
                case Unit.G:
                    serializer.Serialize(writer, "g");
                    return;
                case Unit.GL:
                    serializer.Serialize(writer, "g/L");
                    return;
                case Unit.GCm2S:
                    serializer.Serialize(writer, "g/cm^2 s");
                    return;
                case Unit.GCm3:
                    serializer.Serialize(writer, "g/cm^3");
                    return;
                case Unit.GML:
                    serializer.Serialize(writer, "g/mL");
                    return;
                case Unit.GM3:
                    serializer.Serialize(writer, "g/m^3");
                    return;
                case Unit.GMin:
                    serializer.Serialize(writer, "g/min");
                    return;
                case Unit.GMol:
                    serializer.Serialize(writer, "g/mol");
                    return;
                case Unit.In:
                    serializer.Serialize(writer, "in");
                    return;
                case Unit.KJKKg:
                    serializer.Serialize(writer, "kJ/K kg");
                    return;
                case Unit.KJKg:
                    serializer.Serialize(writer, "kJ/kg");
                    return;
                case Unit.KcalKKg:
                    serializer.Serialize(writer, "kcal/K kg");
                    return;
                case Unit.KcalKS:
                    serializer.Serialize(writer, "kcal/K s");
                    return;
                case Unit.KcalDay:
                    serializer.Serialize(writer, "kcal/day");
                    return;
                case Unit.KcalMol:
                    serializer.Serialize(writer, "kcal/mol");
                    return;
                case Unit.Kg:
                    serializer.Serialize(writer, "kg");
                    return;
                case Unit.KgM3:
                    serializer.Serialize(writer, "kg/m^3");
                    return;
                case Unit.KgMol:
                    serializer.Serialize(writer, "kg/mol");
                    return;
                case Unit.KgS:
                    serializer.Serialize(writer, "kg/s");
                    return;
                case Unit.Lb:
                    serializer.Serialize(writer, "lb");
                    return;
                case Unit.MS:
                    serializer.Serialize(writer, "m/s");
                    return;
                case Unit.ML:
                    serializer.Serialize(writer, "mL");
                    return;
                case Unit.MLMin:
                    serializer.Serialize(writer, "mL/min");
                    return;
                case Unit.MLMinKg:
                    serializer.Serialize(writer, "mL/min kg");
                    return;
                case Unit.MLMinM2:
                    serializer.Serialize(writer, "mL/min m^2");
                    return;
                case Unit.MLMinMmHgM2:
                    serializer.Serialize(writer, "mL/min mmHg m^2");
                    return;
                case Unit.MLMmHg:
                    serializer.Serialize(writer, "mL/mmHg");
                    return;
                case Unit.MLS:
                    serializer.Serialize(writer, "mL/s");
                    return;
                case Unit.MLSKg:
                    serializer.Serialize(writer, "mL/s kg");
                    return;
                case Unit.MLSMmHg:
                    serializer.Serialize(writer, "mL/s mmHg");
                    return;
                case Unit.MLSMmHgM2:
                    serializer.Serialize(writer, "mL/s mmHg m^2");
                    return;
                case Unit.MOsmL:
                    serializer.Serialize(writer, "mOsm/L");
                    return;
                case Unit.MOsmKg:
                    serializer.Serialize(writer, "mOsm/kg");
                    return;
                case Unit.MV:
                    serializer.Serialize(writer, "mV");
                    return;
                case Unit.M2:
                    serializer.Serialize(writer, "m^2");
                    return;
                case Unit.Mg:
                    serializer.Serialize(writer, "mg");
                    return;
                case Unit.MgG:
                    serializer.Serialize(writer, "mg/g");
                    return;
                case Unit.MgML:
                    serializer.Serialize(writer, "mg/mL");
                    return;
                case Unit.MgMin:
                    serializer.Serialize(writer, "mg/min");
                    return;
                case Unit.MgS:
                    serializer.Serialize(writer, "mg/s");
                    return;
                case Unit.Mm:
                    serializer.Serialize(writer, "mm");
                    return;
                case Unit.MmHg:
                    serializer.Serialize(writer, "mmHg");
                    return;
                case Unit.MmHgMinML:
                    serializer.Serialize(writer, "mmHg min/mL");
                    return;
                case Unit.MmHgMinMLM2:
                    serializer.Serialize(writer, "mmHg min/mL m^2");
                    return;
                case Unit.MmHgSML:
                    serializer.Serialize(writer, "mmHg s/mL");
                    return;
                case Unit.MmHgML:
                    serializer.Serialize(writer, "mmHg/mL");
                    return;
                case Unit.MmolL:
                    serializer.Serialize(writer, "mmol/L");
                    return;
                case Unit.MolDay:
                    serializer.Serialize(writer, "mol/day");
                    return;
                case Unit.Ohm:
                    serializer.Serialize(writer, "ohm");
                    return;
                case Unit.PgCt:
                    serializer.Serialize(writer, "pg/ct");
                    return;
                case Unit.PmolMin:
                    serializer.Serialize(writer, "pmol/min");
                    return;
                case Unit.S:
                    serializer.Serialize(writer, "s");
                    return;
                case Unit.UL:
                    serializer.Serialize(writer, "uL");
                    return;
                case Unit.Ug:
                    serializer.Serialize(writer, "ug");
                    return;
                case Unit.UgML:
                    serializer.Serialize(writer, "ug/mL");
                    return;
                case Unit.UmolMin:
                    serializer.Serialize(writer, "umol/min");
                    return;
                case Unit.UmolS:
                    serializer.Serialize(writer, "umol/s");
                    return;
                case Unit.Yr:
                    serializer.Serialize(writer, "yr");
                    return;
            }
            throw new Exception("Cannot marshal type Unit");
        }

        public static readonly UnitConverter Singleton = new UnitConverter();
    }

    internal class ChargeInBloodConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ChargeInBlood) || t == typeof(ChargeInBlood?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Negative":
                    return ChargeInBlood.Negative;
                case "Neutral":
                    return ChargeInBlood.Neutral;
                case "Positive":
                    return ChargeInBlood.Positive;
            }
            throw new Exception("Cannot unmarshal type ChargeInBlood");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ChargeInBlood)untypedValue;
            switch (value)
            {
                case ChargeInBlood.Negative:
                    serializer.Serialize(writer, "Negative");
                    return;
                case ChargeInBlood.Neutral:
                    serializer.Serialize(writer, "Neutral");
                    return;
                case ChargeInBlood.Positive:
                    serializer.Serialize(writer, "Positive");
                    return;
            }
            throw new Exception("Cannot marshal type ChargeInBlood");
        }

        public static readonly ChargeInBloodConverter Singleton = new ChargeInBloodConverter();
    }

    internal class ValueUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ValueUnion) || t == typeof(ValueUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                case JsonToken.Float:
                    var doubleValue = serializer.Deserialize<double>(reader);
                    return new ValueUnion { Double = doubleValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    if (stringValue == "Infinity")
                    {
                        return new ValueUnion { Enum = ValueEnum.Infinity };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type ValueUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ValueUnion)untypedValue;
            if (value.Double != null)
            {
                serializer.Serialize(writer, value.Double.Value);
                return;
            }
            if (value.Enum != null)
            {
                if (value.Enum == ValueEnum.Infinity)
                {
                    serializer.Serialize(writer, "Infinity");
                    return;
                }
            }
            throw new Exception("Cannot marshal type ValueUnion");
        }

        public static readonly ValueUnionConverter Singleton = new ValueUnionConverter();
    }

    internal class ValueEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ValueEnum) || t == typeof(ValueEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Infinity")
            {
                return ValueEnum.Infinity;
            }
            throw new Exception("Cannot unmarshal type ValueEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ValueEnum)untypedValue;
            if (value == ValueEnum.Infinity)
            {
                serializer.Serialize(writer, "Infinity");
                return;
            }
            throw new Exception("Cannot marshal type ValueEnum");
        }

        public static readonly ValueEnumConverter Singleton = new ValueEnumConverter();
    }

    internal class NameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Name) || t == typeof(Name?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Acetoacetate":
                    return Name.Acetoacetate;
                case "Albumin":
                    return Name.Albumin;
                case "Bicarbonate":
                    return Name.Bicarbonate;
                case "Calcium":
                    return Name.Calcium;
                case "Carbaminohemoglobin":
                    return Name.Carbaminohemoglobin;
                case "CarbonDioxide":
                    return Name.CarbonDioxide;
                case "Chloride":
                    return Name.Chloride;
                case "Creatinine":
                    return Name.Creatinine;
                case "Epinephrine":
                    return Name.Epinephrine;
                case "Glucose":
                    return Name.Glucose;
                case "Hemoglobin":
                    return Name.Hemoglobin;
                case "Insulin":
                    return Name.Insulin;
                case "Lactate":
                    return Name.Lactate;
                case "Nitrogen":
                    return Name.Nitrogen;
                case "OxyCarbaminohemoglobin":
                    return Name.OxyCarbaminohemoglobin;
                case "Oxygen":
                    return Name.Oxygen;
                case "Oxyhemoglobin":
                    return Name.Oxyhemoglobin;
                case "Potassium":
                    return Name.Potassium;
                case "Sodium":
                    return Name.Sodium;
                case "Tristearin":
                    return Name.Tristearin;
                case "Urea":
                    return Name.Urea;
            }
            throw new Exception("Cannot unmarshal type Name");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Name)untypedValue;
            switch (value)
            {
                case Name.Acetoacetate:
                    serializer.Serialize(writer, "Acetoacetate");
                    return;
                case Name.Albumin:
                    serializer.Serialize(writer, "Albumin");
                    return;
                case Name.Bicarbonate:
                    serializer.Serialize(writer, "Bicarbonate");
                    return;
                case Name.Calcium:
                    serializer.Serialize(writer, "Calcium");
                    return;
                case Name.Carbaminohemoglobin:
                    serializer.Serialize(writer, "Carbaminohemoglobin");
                    return;
                case Name.CarbonDioxide:
                    serializer.Serialize(writer, "CarbonDioxide");
                    return;
                case Name.Chloride:
                    serializer.Serialize(writer, "Chloride");
                    return;
                case Name.Creatinine:
                    serializer.Serialize(writer, "Creatinine");
                    return;
                case Name.Epinephrine:
                    serializer.Serialize(writer, "Epinephrine");
                    return;
                case Name.Glucose:
                    serializer.Serialize(writer, "Glucose");
                    return;
                case Name.Hemoglobin:
                    serializer.Serialize(writer, "Hemoglobin");
                    return;
                case Name.Insulin:
                    serializer.Serialize(writer, "Insulin");
                    return;
                case Name.Lactate:
                    serializer.Serialize(writer, "Lactate");
                    return;
                case Name.Nitrogen:
                    serializer.Serialize(writer, "Nitrogen");
                    return;
                case Name.OxyCarbaminohemoglobin:
                    serializer.Serialize(writer, "OxyCarbaminohemoglobin");
                    return;
                case Name.Oxygen:
                    serializer.Serialize(writer, "Oxygen");
                    return;
                case Name.Oxyhemoglobin:
                    serializer.Serialize(writer, "Oxyhemoglobin");
                    return;
                case Name.Potassium:
                    serializer.Serialize(writer, "Potassium");
                    return;
                case Name.Sodium:
                    serializer.Serialize(writer, "Sodium");
                    return;
                case Name.Tristearin:
                    serializer.Serialize(writer, "Tristearin");
                    return;
                case Name.Urea:
                    serializer.Serialize(writer, "Urea");
                    return;
            }
            throw new Exception("Cannot marshal type Name");
        }

        public static readonly NameConverter Singleton = new NameConverter();
    }

    internal class StateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(State) || t == typeof(State?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Gas":
                    return State.Gas;
                case "Liquid":
                    return State.Liquid;
                case "Molecular":
                    return State.Molecular;
            }
            throw new Exception("Cannot unmarshal type State");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (State)untypedValue;
            switch (value)
            {
                case State.Gas:
                    serializer.Serialize(writer, "Gas");
                    return;
                case State.Liquid:
                    serializer.Serialize(writer, "Liquid");
                    return;
                case State.Molecular:
                    serializer.Serialize(writer, "Molecular");
                    return;
            }
            throw new Exception("Cannot marshal type State");
        }

        public static readonly StateConverter Singleton = new StateConverter();
    }

    internal class PurpleUnitConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleUnit) || t == typeof(PurpleUnit?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "J":
                    return PurpleUnit.J;
                case "J/K":
                    return PurpleUnit.JK;
                case "K":
                    return PurpleUnit.K;
                case "K/W":
                    return PurpleUnit.KW;
                case "L/cmH2O":
                    return PurpleUnit.LCmH2O;
                case "L/s":
                    return PurpleUnit.LS;
                case "W":
                    return PurpleUnit.W;
                case "cmH2O":
                    return PurpleUnit.CmH2O;
                case "cmH2O s/L":
                    return PurpleUnit.CmH2OSL;
                case "g/dL":
                    return PurpleUnit.GDL;
                case "mL/min":
                    return PurpleUnit.MLMin;
                case "mL/mmHg":
                    return PurpleUnit.MLMmHg;
                case "mL/s":
                    return PurpleUnit.MLS;
                case "mg/L":
                    return PurpleUnit.MgL;
                case "mg/dL":
                    return PurpleUnit.MgDL;
                case "mg/mL":
                    return PurpleUnit.MgML;
                case "mmHg":
                    return PurpleUnit.MmHg;
                case "mmHg s/mL":
                    return PurpleUnit.MmHgSML;
                case "mmol/L":
                    return PurpleUnit.MmolL;
                case "mmol/mL":
                    return PurpleUnit.MmolML;
                case "ug/L":
                    return PurpleUnit.UgL;
                case "ug/mL":
                    return PurpleUnit.UgML;
            }
            throw new Exception("Cannot unmarshal type PurpleUnit");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PurpleUnit)untypedValue;
            switch (value)
            {
                case PurpleUnit.J:
                    serializer.Serialize(writer, "J");
                    return;
                case PurpleUnit.JK:
                    serializer.Serialize(writer, "J/K");
                    return;
                case PurpleUnit.K:
                    serializer.Serialize(writer, "K");
                    return;
                case PurpleUnit.KW:
                    serializer.Serialize(writer, "K/W");
                    return;
                case PurpleUnit.LCmH2O:
                    serializer.Serialize(writer, "L/cmH2O");
                    return;
                case PurpleUnit.LS:
                    serializer.Serialize(writer, "L/s");
                    return;
                case PurpleUnit.W:
                    serializer.Serialize(writer, "W");
                    return;
                case PurpleUnit.CmH2O:
                    serializer.Serialize(writer, "cmH2O");
                    return;
                case PurpleUnit.CmH2OSL:
                    serializer.Serialize(writer, "cmH2O s/L");
                    return;
                case PurpleUnit.GDL:
                    serializer.Serialize(writer, "g/dL");
                    return;
                case PurpleUnit.MLMin:
                    serializer.Serialize(writer, "mL/min");
                    return;
                case PurpleUnit.MLMmHg:
                    serializer.Serialize(writer, "mL/mmHg");
                    return;
                case PurpleUnit.MLS:
                    serializer.Serialize(writer, "mL/s");
                    return;
                case PurpleUnit.MgL:
                    serializer.Serialize(writer, "mg/L");
                    return;
                case PurpleUnit.MgDL:
                    serializer.Serialize(writer, "mg/dL");
                    return;
                case PurpleUnit.MgML:
                    serializer.Serialize(writer, "mg/mL");
                    return;
                case PurpleUnit.MmHg:
                    serializer.Serialize(writer, "mmHg");
                    return;
                case PurpleUnit.MmHgSML:
                    serializer.Serialize(writer, "mmHg s/mL");
                    return;
                case PurpleUnit.MmolL:
                    serializer.Serialize(writer, "mmol/L");
                    return;
                case PurpleUnit.MmolML:
                    serializer.Serialize(writer, "mmol/mL");
                    return;
                case PurpleUnit.UgL:
                    serializer.Serialize(writer, "ug/L");
                    return;
                case PurpleUnit.UgML:
                    serializer.Serialize(writer, "ug/mL");
                    return;
            }
            throw new Exception("Cannot marshal type PurpleUnit");
        }

        public static readonly PurpleUnitConverter Singleton = new PurpleUnitConverter();
    }

    internal class NextPolarizedStateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(NextPolarizedState) || t == typeof(NextPolarizedState?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Closed":
                    return NextPolarizedState.Closed;
                case "Open":
                    return NextPolarizedState.Open;
            }
            throw new Exception("Cannot unmarshal type NextPolarizedState");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (NextPolarizedState)untypedValue;
            switch (value)
            {
                case NextPolarizedState.Closed:
                    serializer.Serialize(writer, "Closed");
                    return;
                case NextPolarizedState.Open:
                    serializer.Serialize(writer, "Open");
                    return;
            }
            throw new Exception("Cannot marshal type NextPolarizedState");
        }

        public static readonly NextPolarizedStateConverter Singleton = new NextPolarizedStateConverter();
    }

    internal class CategoryConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Category) || t == typeof(Category?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Physiology")
            {
                return Category.Physiology;
            }
            throw new Exception("Cannot unmarshal type Category");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Category)untypedValue;
            if (value == Category.Physiology)
            {
                serializer.Serialize(writer, "Physiology");
                return;
            }
            throw new Exception("Cannot marshal type Category");
        }

        public static readonly CategoryConverter Singleton = new CategoryConverter();
    }
}
