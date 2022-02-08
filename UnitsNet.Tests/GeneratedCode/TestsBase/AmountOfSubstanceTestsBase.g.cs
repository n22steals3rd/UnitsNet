//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of AmountOfSubstance.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class AmountOfSubstanceTestsBase : QuantityTestsBase
    {
        protected abstract double CentimolesInOneMole { get; }
        protected abstract double CentipoundMolesInOneMole { get; }
        protected abstract double DecimolesInOneMole { get; }
        protected abstract double DecipoundMolesInOneMole { get; }
        protected abstract double KilomolesInOneMole { get; }
        protected abstract double KilopoundMolesInOneMole { get; }
        protected abstract double MegamolesInOneMole { get; }
        protected abstract double MicromolesInOneMole { get; }
        protected abstract double MicropoundMolesInOneMole { get; }
        protected abstract double MillimolesInOneMole { get; }
        protected abstract double MillipoundMolesInOneMole { get; }
        protected abstract double MolesInOneMole { get; }
        protected abstract double NanomolesInOneMole { get; }
        protected abstract double NanopoundMolesInOneMole { get; }
        protected abstract double PoundMolesInOneMole { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentimolesTolerance { get { return 1e-5; } }
        protected virtual double CentipoundMolesTolerance { get { return 1e-5; } }
        protected virtual double DecimolesTolerance { get { return 1e-5; } }
        protected virtual double DecipoundMolesTolerance { get { return 1e-5; } }
        protected virtual double KilomolesTolerance { get { return 1e-5; } }
        protected virtual double KilopoundMolesTolerance { get { return 1e-5; } }
        protected virtual double MegamolesTolerance { get { return 1e-5; } }
        protected virtual double MicromolesTolerance { get { return 1e-5; } }
        protected virtual double MicropoundMolesTolerance { get { return 1e-5; } }
        protected virtual double MillimolesTolerance { get { return 1e-5; } }
        protected virtual double MillipoundMolesTolerance { get { return 1e-5; } }
        protected virtual double MolesTolerance { get { return 1e-5; } }
        protected virtual double NanomolesTolerance { get { return 1e-5; } }
        protected virtual double NanopoundMolesTolerance { get { return 1e-5; } }
        protected virtual double PoundMolesTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(AmountOfSubstanceUnit unit)
        {
            return unit switch
            {
                AmountOfSubstanceUnit.Centimole => (CentimolesInOneMole, CentimolesTolerance),
                AmountOfSubstanceUnit.CentipoundMole => (CentipoundMolesInOneMole, CentipoundMolesTolerance),
                AmountOfSubstanceUnit.Decimole => (DecimolesInOneMole, DecimolesTolerance),
                AmountOfSubstanceUnit.DecipoundMole => (DecipoundMolesInOneMole, DecipoundMolesTolerance),
                AmountOfSubstanceUnit.Kilomole => (KilomolesInOneMole, KilomolesTolerance),
                AmountOfSubstanceUnit.KilopoundMole => (KilopoundMolesInOneMole, KilopoundMolesTolerance),
                AmountOfSubstanceUnit.Megamole => (MegamolesInOneMole, MegamolesTolerance),
                AmountOfSubstanceUnit.Micromole => (MicromolesInOneMole, MicromolesTolerance),
                AmountOfSubstanceUnit.MicropoundMole => (MicropoundMolesInOneMole, MicropoundMolesTolerance),
                AmountOfSubstanceUnit.Millimole => (MillimolesInOneMole, MillimolesTolerance),
                AmountOfSubstanceUnit.MillipoundMole => (MillipoundMolesInOneMole, MillipoundMolesTolerance),
                AmountOfSubstanceUnit.Mole => (MolesInOneMole, MolesTolerance),
                AmountOfSubstanceUnit.Nanomole => (NanomolesInOneMole, NanomolesTolerance),
                AmountOfSubstanceUnit.NanopoundMole => (NanopoundMolesInOneMole, NanopoundMolesTolerance),
                AmountOfSubstanceUnit.PoundMole => (PoundMolesInOneMole, PoundMolesTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { AmountOfSubstanceUnit.Centimole },
            new object[] { AmountOfSubstanceUnit.CentipoundMole },
            new object[] { AmountOfSubstanceUnit.Decimole },
            new object[] { AmountOfSubstanceUnit.DecipoundMole },
            new object[] { AmountOfSubstanceUnit.Kilomole },
            new object[] { AmountOfSubstanceUnit.KilopoundMole },
            new object[] { AmountOfSubstanceUnit.Megamole },
            new object[] { AmountOfSubstanceUnit.Micromole },
            new object[] { AmountOfSubstanceUnit.MicropoundMole },
            new object[] { AmountOfSubstanceUnit.Millimole },
            new object[] { AmountOfSubstanceUnit.MillipoundMole },
            new object[] { AmountOfSubstanceUnit.Mole },
            new object[] { AmountOfSubstanceUnit.Nanomole },
            new object[] { AmountOfSubstanceUnit.NanopoundMole },
            new object[] { AmountOfSubstanceUnit.PoundMole },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new AmountOfSubstance();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(AmountOfSubstanceUnit.Mole, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new AmountOfSubstance(double.PositiveInfinity, AmountOfSubstanceUnit.Mole));
            Assert.Throws<ArgumentException>(() => new AmountOfSubstance(double.NegativeInfinity, AmountOfSubstanceUnit.Mole));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new AmountOfSubstance(double.NaN, AmountOfSubstanceUnit.Mole));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new AmountOfSubstance(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new AmountOfSubstance(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (AmountOfSubstance) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void AmountOfSubstance_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new AmountOfSubstance(1, AmountOfSubstanceUnit.Mole);

            QuantityInfo<AmountOfSubstanceUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(AmountOfSubstance.Zero, quantityInfo.Zero);
            Assert.Equal("AmountOfSubstance", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<AmountOfSubstanceUnit>().ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void MoleToAmountOfSubstanceUnits()
        {
            AmountOfSubstance mole = AmountOfSubstance.FromMoles(1);
            AssertEx.EqualTolerance(CentimolesInOneMole, mole.Centimoles, CentimolesTolerance);
            AssertEx.EqualTolerance(CentipoundMolesInOneMole, mole.CentipoundMoles, CentipoundMolesTolerance);
            AssertEx.EqualTolerance(DecimolesInOneMole, mole.Decimoles, DecimolesTolerance);
            AssertEx.EqualTolerance(DecipoundMolesInOneMole, mole.DecipoundMoles, DecipoundMolesTolerance);
            AssertEx.EqualTolerance(KilomolesInOneMole, mole.Kilomoles, KilomolesTolerance);
            AssertEx.EqualTolerance(KilopoundMolesInOneMole, mole.KilopoundMoles, KilopoundMolesTolerance);
            AssertEx.EqualTolerance(MegamolesInOneMole, mole.Megamoles, MegamolesTolerance);
            AssertEx.EqualTolerance(MicromolesInOneMole, mole.Micromoles, MicromolesTolerance);
            AssertEx.EqualTolerance(MicropoundMolesInOneMole, mole.MicropoundMoles, MicropoundMolesTolerance);
            AssertEx.EqualTolerance(MillimolesInOneMole, mole.Millimoles, MillimolesTolerance);
            AssertEx.EqualTolerance(MillipoundMolesInOneMole, mole.MillipoundMoles, MillipoundMolesTolerance);
            AssertEx.EqualTolerance(MolesInOneMole, mole.Moles, MolesTolerance);
            AssertEx.EqualTolerance(NanomolesInOneMole, mole.Nanomoles, NanomolesTolerance);
            AssertEx.EqualTolerance(NanopoundMolesInOneMole, mole.NanopoundMoles, NanopoundMolesTolerance);
            AssertEx.EqualTolerance(PoundMolesInOneMole, mole.PoundMoles, PoundMolesTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.Centimole);
            AssertEx.EqualTolerance(1, quantity00.Centimoles, CentimolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Centimole, quantity00.Unit);

            var quantity01 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.CentipoundMole);
            AssertEx.EqualTolerance(1, quantity01.CentipoundMoles, CentipoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.CentipoundMole, quantity01.Unit);

            var quantity02 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.Decimole);
            AssertEx.EqualTolerance(1, quantity02.Decimoles, DecimolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Decimole, quantity02.Unit);

            var quantity03 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.DecipoundMole);
            AssertEx.EqualTolerance(1, quantity03.DecipoundMoles, DecipoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.DecipoundMole, quantity03.Unit);

            var quantity04 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.Kilomole);
            AssertEx.EqualTolerance(1, quantity04.Kilomoles, KilomolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Kilomole, quantity04.Unit);

            var quantity05 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.KilopoundMole);
            AssertEx.EqualTolerance(1, quantity05.KilopoundMoles, KilopoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.KilopoundMole, quantity05.Unit);

            var quantity06 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.Megamole);
            AssertEx.EqualTolerance(1, quantity06.Megamoles, MegamolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Megamole, quantity06.Unit);

            var quantity07 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.Micromole);
            AssertEx.EqualTolerance(1, quantity07.Micromoles, MicromolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Micromole, quantity07.Unit);

            var quantity08 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.MicropoundMole);
            AssertEx.EqualTolerance(1, quantity08.MicropoundMoles, MicropoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.MicropoundMole, quantity08.Unit);

            var quantity09 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.Millimole);
            AssertEx.EqualTolerance(1, quantity09.Millimoles, MillimolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Millimole, quantity09.Unit);

            var quantity10 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.MillipoundMole);
            AssertEx.EqualTolerance(1, quantity10.MillipoundMoles, MillipoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.MillipoundMole, quantity10.Unit);

            var quantity11 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.Mole);
            AssertEx.EqualTolerance(1, quantity11.Moles, MolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Mole, quantity11.Unit);

            var quantity12 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.Nanomole);
            AssertEx.EqualTolerance(1, quantity12.Nanomoles, NanomolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Nanomole, quantity12.Unit);

            var quantity13 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.NanopoundMole);
            AssertEx.EqualTolerance(1, quantity13.NanopoundMoles, NanopoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.NanopoundMole, quantity13.Unit);

            var quantity14 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.PoundMole);
            AssertEx.EqualTolerance(1, quantity14.PoundMoles, PoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.PoundMole, quantity14.Unit);

        }

        [Fact]
        public void FromMoles_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => AmountOfSubstance.FromMoles(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => AmountOfSubstance.FromMoles(double.NegativeInfinity));
        }

        [Fact]
        public void FromMoles_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => AmountOfSubstance.FromMoles(double.NaN));
        }

        [Fact]
        public void As()
        {
            var mole = AmountOfSubstance.FromMoles(1);
            AssertEx.EqualTolerance(CentimolesInOneMole, mole.As(AmountOfSubstanceUnit.Centimole), CentimolesTolerance);
            AssertEx.EqualTolerance(CentipoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.CentipoundMole), CentipoundMolesTolerance);
            AssertEx.EqualTolerance(DecimolesInOneMole, mole.As(AmountOfSubstanceUnit.Decimole), DecimolesTolerance);
            AssertEx.EqualTolerance(DecipoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.DecipoundMole), DecipoundMolesTolerance);
            AssertEx.EqualTolerance(KilomolesInOneMole, mole.As(AmountOfSubstanceUnit.Kilomole), KilomolesTolerance);
            AssertEx.EqualTolerance(KilopoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.KilopoundMole), KilopoundMolesTolerance);
            AssertEx.EqualTolerance(MegamolesInOneMole, mole.As(AmountOfSubstanceUnit.Megamole), MegamolesTolerance);
            AssertEx.EqualTolerance(MicromolesInOneMole, mole.As(AmountOfSubstanceUnit.Micromole), MicromolesTolerance);
            AssertEx.EqualTolerance(MicropoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.MicropoundMole), MicropoundMolesTolerance);
            AssertEx.EqualTolerance(MillimolesInOneMole, mole.As(AmountOfSubstanceUnit.Millimole), MillimolesTolerance);
            AssertEx.EqualTolerance(MillipoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.MillipoundMole), MillipoundMolesTolerance);
            AssertEx.EqualTolerance(MolesInOneMole, mole.As(AmountOfSubstanceUnit.Mole), MolesTolerance);
            AssertEx.EqualTolerance(NanomolesInOneMole, mole.As(AmountOfSubstanceUnit.Nanomole), NanomolesTolerance);
            AssertEx.EqualTolerance(NanopoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.NanopoundMole), NanopoundMolesTolerance);
            AssertEx.EqualTolerance(PoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.PoundMole), PoundMolesTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new AmountOfSubstance(value: 1, unit: AmountOfSubstance.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (double) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit(AmountOfSubstanceUnit unit)
        {
            var inBaseUnits = AmountOfSubstance.From(1.0, AmountOfSubstance.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, (double)converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(AmountOfSubstanceUnit unit)
        {
            var quantity = AmountOfSubstance.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(AmountOfSubstanceUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = AmountOfSubstance.Units.FirstOrDefault(u => u != AmountOfSubstance.BaseUnit);

            var quantity = AmountOfSubstance.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            AmountOfSubstance mole = AmountOfSubstance.FromMoles(1);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromCentimoles(mole.Centimoles).Moles, CentimolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromCentipoundMoles(mole.CentipoundMoles).Moles, CentipoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromDecimoles(mole.Decimoles).Moles, DecimolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromDecipoundMoles(mole.DecipoundMoles).Moles, DecipoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromKilomoles(mole.Kilomoles).Moles, KilomolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromKilopoundMoles(mole.KilopoundMoles).Moles, KilopoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromMegamoles(mole.Megamoles).Moles, MegamolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromMicromoles(mole.Micromoles).Moles, MicromolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromMicropoundMoles(mole.MicropoundMoles).Moles, MicropoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromMillimoles(mole.Millimoles).Moles, MillimolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromMillipoundMoles(mole.MillipoundMoles).Moles, MillipoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromMoles(mole.Moles).Moles, MolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromNanomoles(mole.Nanomoles).Moles, NanomolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromNanopoundMoles(mole.NanopoundMoles).Moles, NanopoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromPoundMoles(mole.PoundMoles).Moles, PoundMolesTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            AmountOfSubstance v = AmountOfSubstance.FromMoles(1);
            AssertEx.EqualTolerance(-1, -v.Moles, MolesTolerance);
            AssertEx.EqualTolerance(2, (AmountOfSubstance.FromMoles(3)-v).Moles, MolesTolerance);
            AssertEx.EqualTolerance(2, (v + v).Moles, MolesTolerance);
            AssertEx.EqualTolerance(10, (v*10).Moles, MolesTolerance);
            AssertEx.EqualTolerance(10, (10*v).Moles, MolesTolerance);
            AssertEx.EqualTolerance(2, (AmountOfSubstance.FromMoles(10)/5).Moles, MolesTolerance);
            AssertEx.EqualTolerance(2, AmountOfSubstance.FromMoles(10)/AmountOfSubstance.FromMoles(5), MolesTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            AmountOfSubstance oneMole = AmountOfSubstance.FromMoles(1);
            AmountOfSubstance twoMoles = AmountOfSubstance.FromMoles(2);

            Assert.True(oneMole < twoMoles);
            Assert.True(oneMole <= twoMoles);
            Assert.True(twoMoles > oneMole);
            Assert.True(twoMoles >= oneMole);

            Assert.False(oneMole > twoMoles);
            Assert.False(oneMole >= twoMoles);
            Assert.False(twoMoles < oneMole);
            Assert.False(twoMoles <= oneMole);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            AmountOfSubstance mole = AmountOfSubstance.FromMoles(1);
            Assert.Equal(0, mole.CompareTo(mole));
            Assert.True(mole.CompareTo(AmountOfSubstance.Zero) > 0);
            Assert.True(AmountOfSubstance.Zero.CompareTo(mole) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            AmountOfSubstance mole = AmountOfSubstance.FromMoles(1);
            Assert.Throws<ArgumentException>(() => mole.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            AmountOfSubstance mole = AmountOfSubstance.FromMoles(1);
            Assert.Throws<ArgumentNullException>(() => mole.CompareTo(null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = AmountOfSubstance.FromMoles(1);
            Assert.True(v.Equals(AmountOfSubstance.FromMoles(1), MolesTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(AmountOfSubstance.Zero, MolesTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = AmountOfSubstance.FromMoles(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(AmountOfSubstance.FromMoles(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            AmountOfSubstance mole = AmountOfSubstance.FromMoles(1);
            Assert.False(mole.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            AmountOfSubstance mole = AmountOfSubstance.FromMoles(1);
            Assert.False(mole.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(AmountOfSubstanceUnit)).Cast<AmountOfSubstanceUnit>();
            foreach(var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(AmountOfSubstance.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 cmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Centimole).ToString());
                Assert.Equal("1 clbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.CentipoundMole).ToString());
                Assert.Equal("1 dmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Decimole).ToString());
                Assert.Equal("1 dlbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.DecipoundMole).ToString());
                Assert.Equal("1 kmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Kilomole).ToString());
                Assert.Equal("1 klbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.KilopoundMole).ToString());
                Assert.Equal("1 Mmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Megamole).ToString());
                Assert.Equal("1 µmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Micromole).ToString());
                Assert.Equal("1 µlbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.MicropoundMole).ToString());
                Assert.Equal("1 mmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Millimole).ToString());
                Assert.Equal("1 mlbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.MillipoundMole).ToString());
                Assert.Equal("1 mol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Mole).ToString());
                Assert.Equal("1 nmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Nanomole).ToString());
                Assert.Equal("1 nlbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.NanopoundMole).ToString());
                Assert.Equal("1 lbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.PoundMole).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentCulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 cmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Centimole).ToString(swedishCulture));
            Assert.Equal("1 clbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.CentipoundMole).ToString(swedishCulture));
            Assert.Equal("1 dmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Decimole).ToString(swedishCulture));
            Assert.Equal("1 dlbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.DecipoundMole).ToString(swedishCulture));
            Assert.Equal("1 kmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Kilomole).ToString(swedishCulture));
            Assert.Equal("1 klbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.KilopoundMole).ToString(swedishCulture));
            Assert.Equal("1 Mmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Megamole).ToString(swedishCulture));
            Assert.Equal("1 µmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Micromole).ToString(swedishCulture));
            Assert.Equal("1 µlbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.MicropoundMole).ToString(swedishCulture));
            Assert.Equal("1 mmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Millimole).ToString(swedishCulture));
            Assert.Equal("1 mlbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.MillipoundMole).ToString(swedishCulture));
            Assert.Equal("1 mol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Mole).ToString(swedishCulture));
            Assert.Equal("1 nmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Nanomole).ToString(swedishCulture));
            Assert.Equal("1 nlbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.NanopoundMole).ToString(swedishCulture));
            Assert.Equal("1 lbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.PoundMole).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 mol", new AmountOfSubstance(0.123456, AmountOfSubstanceUnit.Mole).ToString("s1"));
                Assert.Equal("0.12 mol", new AmountOfSubstance(0.123456, AmountOfSubstanceUnit.Mole).ToString("s2"));
                Assert.Equal("0.123 mol", new AmountOfSubstance(0.123456, AmountOfSubstanceUnit.Mole).ToString("s3"));
                Assert.Equal("0.1235 mol", new AmountOfSubstance(0.123456, AmountOfSubstanceUnit.Mole).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentCulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 mol", new AmountOfSubstance(0.123456, AmountOfSubstanceUnit.Mole).ToString("s1", culture));
            Assert.Equal("0.12 mol", new AmountOfSubstance(0.123456, AmountOfSubstanceUnit.Mole).ToString("s2", culture));
            Assert.Equal("0.123 mol", new AmountOfSubstance(0.123456, AmountOfSubstanceUnit.Mole).ToString("s3", culture));
            Assert.Equal("0.1235 mol", new AmountOfSubstance(0.123456, AmountOfSubstanceUnit.Mole).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            CultureInfo formatProvider = cultureName == null
                ? null
                : CultureInfo.GetCultureInfo(cultureName);

            Assert.Equal(quantity.ToString("g", formatProvider), quantity.ToString(null, formatProvider));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("g")]
        public void ToString_NullProvider_EqualsCurrentCulture(string format)
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(AmountOfSubstance)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(AmountOfSubstanceUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Equal(AmountOfSubstance.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Equal(AmountOfSubstance.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Equal(new {AmountOfSubstance.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = AmountOfSubstance.FromMoles(value);
            Assert.Equal(AmountOfSubstance.FromMoles(-value), -quantity);
        }
    }
}
