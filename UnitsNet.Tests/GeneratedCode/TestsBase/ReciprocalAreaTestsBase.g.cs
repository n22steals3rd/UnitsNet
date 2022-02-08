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
    /// Test of ReciprocalArea.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ReciprocalAreaTestsBase : QuantityTestsBase
    {
        protected abstract double InverseSquareCentimetersInOneInverseSquareMeter { get; }
        protected abstract double InverseSquareDecimetersInOneInverseSquareMeter { get; }
        protected abstract double InverseSquareFeetInOneInverseSquareMeter { get; }
        protected abstract double InverseSquareInchesInOneInverseSquareMeter { get; }
        protected abstract double InverseSquareKilometersInOneInverseSquareMeter { get; }
        protected abstract double InverseSquareMetersInOneInverseSquareMeter { get; }
        protected abstract double InverseSquareMicrometersInOneInverseSquareMeter { get; }
        protected abstract double InverseSquareMilesInOneInverseSquareMeter { get; }
        protected abstract double InverseSquareMillimetersInOneInverseSquareMeter { get; }
        protected abstract double InverseSquareYardsInOneInverseSquareMeter { get; }
        protected abstract double InverseUsSurveySquareFeetInOneInverseSquareMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double InverseSquareCentimetersTolerance { get { return 1e-5; } }
        protected virtual double InverseSquareDecimetersTolerance { get { return 1e-5; } }
        protected virtual double InverseSquareFeetTolerance { get { return 1e-5; } }
        protected virtual double InverseSquareInchesTolerance { get { return 1e-5; } }
        protected virtual double InverseSquareKilometersTolerance { get { return 1e-5; } }
        protected virtual double InverseSquareMetersTolerance { get { return 1e-5; } }
        protected virtual double InverseSquareMicrometersTolerance { get { return 1e-5; } }
        protected virtual double InverseSquareMilesTolerance { get { return 1e-5; } }
        protected virtual double InverseSquareMillimetersTolerance { get { return 1e-5; } }
        protected virtual double InverseSquareYardsTolerance { get { return 1e-5; } }
        protected virtual double InverseUsSurveySquareFeetTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        protected (double UnitsInBaseUnit, double Tolerence) GetConversionFactor(ReciprocalAreaUnit unit)
        {
            return unit switch
            {
                ReciprocalAreaUnit.InverseSquareCentimeter => (InverseSquareCentimetersInOneInverseSquareMeter, InverseSquareCentimetersTolerance),
                ReciprocalAreaUnit.InverseSquareDecimeter => (InverseSquareDecimetersInOneInverseSquareMeter, InverseSquareDecimetersTolerance),
                ReciprocalAreaUnit.InverseSquareFoot => (InverseSquareFeetInOneInverseSquareMeter, InverseSquareFeetTolerance),
                ReciprocalAreaUnit.InverseSquareInch => (InverseSquareInchesInOneInverseSquareMeter, InverseSquareInchesTolerance),
                ReciprocalAreaUnit.InverseSquareKilometer => (InverseSquareKilometersInOneInverseSquareMeter, InverseSquareKilometersTolerance),
                ReciprocalAreaUnit.InverseSquareMeter => (InverseSquareMetersInOneInverseSquareMeter, InverseSquareMetersTolerance),
                ReciprocalAreaUnit.InverseSquareMicrometer => (InverseSquareMicrometersInOneInverseSquareMeter, InverseSquareMicrometersTolerance),
                ReciprocalAreaUnit.InverseSquareMile => (InverseSquareMilesInOneInverseSquareMeter, InverseSquareMilesTolerance),
                ReciprocalAreaUnit.InverseSquareMillimeter => (InverseSquareMillimetersInOneInverseSquareMeter, InverseSquareMillimetersTolerance),
                ReciprocalAreaUnit.InverseSquareYard => (InverseSquareYardsInOneInverseSquareMeter, InverseSquareYardsTolerance),
                ReciprocalAreaUnit.InverseUsSurveySquareFoot => (InverseUsSurveySquareFeetInOneInverseSquareMeter, InverseUsSurveySquareFeetTolerance),
                _ => throw new NotSupportedException()
            };
        }

        public static IEnumerable<object[]> UnitTypes = new List<object[]>
        {
            new object[] { ReciprocalAreaUnit.InverseSquareCentimeter },
            new object[] { ReciprocalAreaUnit.InverseSquareDecimeter },
            new object[] { ReciprocalAreaUnit.InverseSquareFoot },
            new object[] { ReciprocalAreaUnit.InverseSquareInch },
            new object[] { ReciprocalAreaUnit.InverseSquareKilometer },
            new object[] { ReciprocalAreaUnit.InverseSquareMeter },
            new object[] { ReciprocalAreaUnit.InverseSquareMicrometer },
            new object[] { ReciprocalAreaUnit.InverseSquareMile },
            new object[] { ReciprocalAreaUnit.InverseSquareMillimeter },
            new object[] { ReciprocalAreaUnit.InverseSquareYard },
            new object[] { ReciprocalAreaUnit.InverseUsSurveySquareFoot },
        };

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ReciprocalArea();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ReciprocalAreaUnit.InverseSquareMeter, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ReciprocalArea(double.PositiveInfinity, ReciprocalAreaUnit.InverseSquareMeter));
            Assert.Throws<ArgumentException>(() => new ReciprocalArea(double.NegativeInfinity, ReciprocalAreaUnit.InverseSquareMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ReciprocalArea(double.NaN, ReciprocalAreaUnit.InverseSquareMeter));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ReciprocalArea(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new ReciprocalArea(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (ReciprocalArea) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void ReciprocalArea_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareMeter);

            QuantityInfo<ReciprocalAreaUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ReciprocalArea.Zero, quantityInfo.Zero);
            Assert.Equal("ReciprocalArea", quantityInfo.Name);

            var units = EnumUtils.GetEnumValues<ReciprocalAreaUnit>().ToArray();
            var unitNames = units.Select(x => x.ToString());
        }

        [Fact]
        public void InverseSquareMeterToReciprocalAreaUnits()
        {
            ReciprocalArea inversesquaremeter = ReciprocalArea.FromInverseSquareMeters(1);
            AssertEx.EqualTolerance(InverseSquareCentimetersInOneInverseSquareMeter, inversesquaremeter.InverseSquareCentimeters, InverseSquareCentimetersTolerance);
            AssertEx.EqualTolerance(InverseSquareDecimetersInOneInverseSquareMeter, inversesquaremeter.InverseSquareDecimeters, InverseSquareDecimetersTolerance);
            AssertEx.EqualTolerance(InverseSquareFeetInOneInverseSquareMeter, inversesquaremeter.InverseSquareFeet, InverseSquareFeetTolerance);
            AssertEx.EqualTolerance(InverseSquareInchesInOneInverseSquareMeter, inversesquaremeter.InverseSquareInches, InverseSquareInchesTolerance);
            AssertEx.EqualTolerance(InverseSquareKilometersInOneInverseSquareMeter, inversesquaremeter.InverseSquareKilometers, InverseSquareKilometersTolerance);
            AssertEx.EqualTolerance(InverseSquareMetersInOneInverseSquareMeter, inversesquaremeter.InverseSquareMeters, InverseSquareMetersTolerance);
            AssertEx.EqualTolerance(InverseSquareMicrometersInOneInverseSquareMeter, inversesquaremeter.InverseSquareMicrometers, InverseSquareMicrometersTolerance);
            AssertEx.EqualTolerance(InverseSquareMilesInOneInverseSquareMeter, inversesquaremeter.InverseSquareMiles, InverseSquareMilesTolerance);
            AssertEx.EqualTolerance(InverseSquareMillimetersInOneInverseSquareMeter, inversesquaremeter.InverseSquareMillimeters, InverseSquareMillimetersTolerance);
            AssertEx.EqualTolerance(InverseSquareYardsInOneInverseSquareMeter, inversesquaremeter.InverseSquareYards, InverseSquareYardsTolerance);
            AssertEx.EqualTolerance(InverseUsSurveySquareFeetInOneInverseSquareMeter, inversesquaremeter.InverseUsSurveySquareFeet, InverseUsSurveySquareFeetTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ReciprocalArea.From(1, ReciprocalAreaUnit.InverseSquareCentimeter);
            AssertEx.EqualTolerance(1, quantity00.InverseSquareCentimeters, InverseSquareCentimetersTolerance);
            Assert.Equal(ReciprocalAreaUnit.InverseSquareCentimeter, quantity00.Unit);

            var quantity01 = ReciprocalArea.From(1, ReciprocalAreaUnit.InverseSquareDecimeter);
            AssertEx.EqualTolerance(1, quantity01.InverseSquareDecimeters, InverseSquareDecimetersTolerance);
            Assert.Equal(ReciprocalAreaUnit.InverseSquareDecimeter, quantity01.Unit);

            var quantity02 = ReciprocalArea.From(1, ReciprocalAreaUnit.InverseSquareFoot);
            AssertEx.EqualTolerance(1, quantity02.InverseSquareFeet, InverseSquareFeetTolerance);
            Assert.Equal(ReciprocalAreaUnit.InverseSquareFoot, quantity02.Unit);

            var quantity03 = ReciprocalArea.From(1, ReciprocalAreaUnit.InverseSquareInch);
            AssertEx.EqualTolerance(1, quantity03.InverseSquareInches, InverseSquareInchesTolerance);
            Assert.Equal(ReciprocalAreaUnit.InverseSquareInch, quantity03.Unit);

            var quantity04 = ReciprocalArea.From(1, ReciprocalAreaUnit.InverseSquareKilometer);
            AssertEx.EqualTolerance(1, quantity04.InverseSquareKilometers, InverseSquareKilometersTolerance);
            Assert.Equal(ReciprocalAreaUnit.InverseSquareKilometer, quantity04.Unit);

            var quantity05 = ReciprocalArea.From(1, ReciprocalAreaUnit.InverseSquareMeter);
            AssertEx.EqualTolerance(1, quantity05.InverseSquareMeters, InverseSquareMetersTolerance);
            Assert.Equal(ReciprocalAreaUnit.InverseSquareMeter, quantity05.Unit);

            var quantity06 = ReciprocalArea.From(1, ReciprocalAreaUnit.InverseSquareMicrometer);
            AssertEx.EqualTolerance(1, quantity06.InverseSquareMicrometers, InverseSquareMicrometersTolerance);
            Assert.Equal(ReciprocalAreaUnit.InverseSquareMicrometer, quantity06.Unit);

            var quantity07 = ReciprocalArea.From(1, ReciprocalAreaUnit.InverseSquareMile);
            AssertEx.EqualTolerance(1, quantity07.InverseSquareMiles, InverseSquareMilesTolerance);
            Assert.Equal(ReciprocalAreaUnit.InverseSquareMile, quantity07.Unit);

            var quantity08 = ReciprocalArea.From(1, ReciprocalAreaUnit.InverseSquareMillimeter);
            AssertEx.EqualTolerance(1, quantity08.InverseSquareMillimeters, InverseSquareMillimetersTolerance);
            Assert.Equal(ReciprocalAreaUnit.InverseSquareMillimeter, quantity08.Unit);

            var quantity09 = ReciprocalArea.From(1, ReciprocalAreaUnit.InverseSquareYard);
            AssertEx.EqualTolerance(1, quantity09.InverseSquareYards, InverseSquareYardsTolerance);
            Assert.Equal(ReciprocalAreaUnit.InverseSquareYard, quantity09.Unit);

            var quantity10 = ReciprocalArea.From(1, ReciprocalAreaUnit.InverseUsSurveySquareFoot);
            AssertEx.EqualTolerance(1, quantity10.InverseUsSurveySquareFeet, InverseUsSurveySquareFeetTolerance);
            Assert.Equal(ReciprocalAreaUnit.InverseUsSurveySquareFoot, quantity10.Unit);

        }

        [Fact]
        public void FromInverseSquareMeters_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ReciprocalArea.FromInverseSquareMeters(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ReciprocalArea.FromInverseSquareMeters(double.NegativeInfinity));
        }

        [Fact]
        public void FromInverseSquareMeters_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ReciprocalArea.FromInverseSquareMeters(double.NaN));
        }

        [Fact]
        public void As()
        {
            var inversesquaremeter = ReciprocalArea.FromInverseSquareMeters(1);
            AssertEx.EqualTolerance(InverseSquareCentimetersInOneInverseSquareMeter, inversesquaremeter.As(ReciprocalAreaUnit.InverseSquareCentimeter), InverseSquareCentimetersTolerance);
            AssertEx.EqualTolerance(InverseSquareDecimetersInOneInverseSquareMeter, inversesquaremeter.As(ReciprocalAreaUnit.InverseSquareDecimeter), InverseSquareDecimetersTolerance);
            AssertEx.EqualTolerance(InverseSquareFeetInOneInverseSquareMeter, inversesquaremeter.As(ReciprocalAreaUnit.InverseSquareFoot), InverseSquareFeetTolerance);
            AssertEx.EqualTolerance(InverseSquareInchesInOneInverseSquareMeter, inversesquaremeter.As(ReciprocalAreaUnit.InverseSquareInch), InverseSquareInchesTolerance);
            AssertEx.EqualTolerance(InverseSquareKilometersInOneInverseSquareMeter, inversesquaremeter.As(ReciprocalAreaUnit.InverseSquareKilometer), InverseSquareKilometersTolerance);
            AssertEx.EqualTolerance(InverseSquareMetersInOneInverseSquareMeter, inversesquaremeter.As(ReciprocalAreaUnit.InverseSquareMeter), InverseSquareMetersTolerance);
            AssertEx.EqualTolerance(InverseSquareMicrometersInOneInverseSquareMeter, inversesquaremeter.As(ReciprocalAreaUnit.InverseSquareMicrometer), InverseSquareMicrometersTolerance);
            AssertEx.EqualTolerance(InverseSquareMilesInOneInverseSquareMeter, inversesquaremeter.As(ReciprocalAreaUnit.InverseSquareMile), InverseSquareMilesTolerance);
            AssertEx.EqualTolerance(InverseSquareMillimetersInOneInverseSquareMeter, inversesquaremeter.As(ReciprocalAreaUnit.InverseSquareMillimeter), InverseSquareMillimetersTolerance);
            AssertEx.EqualTolerance(InverseSquareYardsInOneInverseSquareMeter, inversesquaremeter.As(ReciprocalAreaUnit.InverseSquareYard), InverseSquareYardsTolerance);
            AssertEx.EqualTolerance(InverseUsSurveySquareFeetInOneInverseSquareMeter, inversesquaremeter.As(ReciprocalAreaUnit.InverseUsSurveySquareFoot), InverseUsSurveySquareFeetTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new ReciprocalArea(value: 1, unit: ReciprocalArea.BaseUnit);
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
        public void ToUnit(ReciprocalAreaUnit unit)
        {
            var inBaseUnits = ReciprocalArea.From(1.0, ReciprocalArea.BaseUnit);
            var converted = inBaseUnits.ToUnit(unit);

            var conversionFactor = GetConversionFactor(unit);
            AssertEx.EqualTolerance(conversionFactor.UnitsInBaseUnit, (double)converted.Value, conversionFactor.Tolerence);
            Assert.Equal(unit, converted.Unit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_WithSameUnits_AreEqual(ReciprocalAreaUnit unit)
        {
            var quantity = ReciprocalArea.From(3.0, unit);
            var toUnitWithSameUnit = quantity.ToUnit(unit);
            Assert.Equal(quantity, toUnitWithSameUnit);
        }

        [Theory]
        [MemberData(nameof(UnitTypes))]
        public void ToUnit_FromNonBaseUnit_ReturnsQuantityWithGivenUnit(ReciprocalAreaUnit unit)
        {
            // See if there is a unit available that is not the base unit, fallback to base unit if it has only a single unit.
            var fromUnit = ReciprocalArea.Units.FirstOrDefault(u => u != ReciprocalArea.BaseUnit);

            var quantity = ReciprocalArea.From(3.0, fromUnit);
            var converted = quantity.ToUnit(unit);
            Assert.Equal(converted.Unit, unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ReciprocalArea inversesquaremeter = ReciprocalArea.FromInverseSquareMeters(1);
            AssertEx.EqualTolerance(1, ReciprocalArea.FromInverseSquareCentimeters(inversesquaremeter.InverseSquareCentimeters).InverseSquareMeters, InverseSquareCentimetersTolerance);
            AssertEx.EqualTolerance(1, ReciprocalArea.FromInverseSquareDecimeters(inversesquaremeter.InverseSquareDecimeters).InverseSquareMeters, InverseSquareDecimetersTolerance);
            AssertEx.EqualTolerance(1, ReciprocalArea.FromInverseSquareFeet(inversesquaremeter.InverseSquareFeet).InverseSquareMeters, InverseSquareFeetTolerance);
            AssertEx.EqualTolerance(1, ReciprocalArea.FromInverseSquareInches(inversesquaremeter.InverseSquareInches).InverseSquareMeters, InverseSquareInchesTolerance);
            AssertEx.EqualTolerance(1, ReciprocalArea.FromInverseSquareKilometers(inversesquaremeter.InverseSquareKilometers).InverseSquareMeters, InverseSquareKilometersTolerance);
            AssertEx.EqualTolerance(1, ReciprocalArea.FromInverseSquareMeters(inversesquaremeter.InverseSquareMeters).InverseSquareMeters, InverseSquareMetersTolerance);
            AssertEx.EqualTolerance(1, ReciprocalArea.FromInverseSquareMicrometers(inversesquaremeter.InverseSquareMicrometers).InverseSquareMeters, InverseSquareMicrometersTolerance);
            AssertEx.EqualTolerance(1, ReciprocalArea.FromInverseSquareMiles(inversesquaremeter.InverseSquareMiles).InverseSquareMeters, InverseSquareMilesTolerance);
            AssertEx.EqualTolerance(1, ReciprocalArea.FromInverseSquareMillimeters(inversesquaremeter.InverseSquareMillimeters).InverseSquareMeters, InverseSquareMillimetersTolerance);
            AssertEx.EqualTolerance(1, ReciprocalArea.FromInverseSquareYards(inversesquaremeter.InverseSquareYards).InverseSquareMeters, InverseSquareYardsTolerance);
            AssertEx.EqualTolerance(1, ReciprocalArea.FromInverseUsSurveySquareFeet(inversesquaremeter.InverseUsSurveySquareFeet).InverseSquareMeters, InverseUsSurveySquareFeetTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ReciprocalArea v = ReciprocalArea.FromInverseSquareMeters(1);
            AssertEx.EqualTolerance(-1, -v.InverseSquareMeters, InverseSquareMetersTolerance);
            AssertEx.EqualTolerance(2, (ReciprocalArea.FromInverseSquareMeters(3)-v).InverseSquareMeters, InverseSquareMetersTolerance);
            AssertEx.EqualTolerance(2, (v + v).InverseSquareMeters, InverseSquareMetersTolerance);
            AssertEx.EqualTolerance(10, (v*10).InverseSquareMeters, InverseSquareMetersTolerance);
            AssertEx.EqualTolerance(10, (10*v).InverseSquareMeters, InverseSquareMetersTolerance);
            AssertEx.EqualTolerance(2, (ReciprocalArea.FromInverseSquareMeters(10)/5).InverseSquareMeters, InverseSquareMetersTolerance);
            AssertEx.EqualTolerance(2, ReciprocalArea.FromInverseSquareMeters(10)/ReciprocalArea.FromInverseSquareMeters(5), InverseSquareMetersTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ReciprocalArea oneInverseSquareMeter = ReciprocalArea.FromInverseSquareMeters(1);
            ReciprocalArea twoInverseSquareMeters = ReciprocalArea.FromInverseSquareMeters(2);

            Assert.True(oneInverseSquareMeter < twoInverseSquareMeters);
            Assert.True(oneInverseSquareMeter <= twoInverseSquareMeters);
            Assert.True(twoInverseSquareMeters > oneInverseSquareMeter);
            Assert.True(twoInverseSquareMeters >= oneInverseSquareMeter);

            Assert.False(oneInverseSquareMeter > twoInverseSquareMeters);
            Assert.False(oneInverseSquareMeter >= twoInverseSquareMeters);
            Assert.False(twoInverseSquareMeters < oneInverseSquareMeter);
            Assert.False(twoInverseSquareMeters <= oneInverseSquareMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ReciprocalArea inversesquaremeter = ReciprocalArea.FromInverseSquareMeters(1);
            Assert.Equal(0, inversesquaremeter.CompareTo(inversesquaremeter));
            Assert.True(inversesquaremeter.CompareTo(ReciprocalArea.Zero) > 0);
            Assert.True(ReciprocalArea.Zero.CompareTo(inversesquaremeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ReciprocalArea inversesquaremeter = ReciprocalArea.FromInverseSquareMeters(1);
            Assert.Throws<ArgumentException>(() => inversesquaremeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ReciprocalArea inversesquaremeter = ReciprocalArea.FromInverseSquareMeters(1);
            Assert.Throws<ArgumentNullException>(() => inversesquaremeter.CompareTo(null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = ReciprocalArea.FromInverseSquareMeters(1);
            Assert.True(v.Equals(ReciprocalArea.FromInverseSquareMeters(1), InverseSquareMetersTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ReciprocalArea.Zero, InverseSquareMetersTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ReciprocalArea.FromInverseSquareMeters(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ReciprocalArea.FromInverseSquareMeters(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ReciprocalArea inversesquaremeter = ReciprocalArea.FromInverseSquareMeters(1);
            Assert.False(inversesquaremeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ReciprocalArea inversesquaremeter = ReciprocalArea.FromInverseSquareMeters(1);
            Assert.False(inversesquaremeter.Equals(null));
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ReciprocalAreaUnit)).Cast<ReciprocalAreaUnit>();
            foreach(var unit in units)
            {
                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ReciprocalArea.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 cm⁻²", new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareCentimeter).ToString());
                Assert.Equal("1 dm⁻²", new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareDecimeter).ToString());
                Assert.Equal("1 ft⁻²", new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareFoot).ToString());
                Assert.Equal("1 in⁻²", new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareInch).ToString());
                Assert.Equal("1 km⁻²", new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareKilometer).ToString());
                Assert.Equal("1 m⁻²", new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareMeter).ToString());
                Assert.Equal("1 µm⁻²", new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareMicrometer).ToString());
                Assert.Equal("1 mi⁻²", new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareMile).ToString());
                Assert.Equal("1 mm⁻²", new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareMillimeter).ToString());
                Assert.Equal("1 yd⁻²", new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareYard).ToString());
                Assert.Equal("1 ft⁻² (US)", new ReciprocalArea(1, ReciprocalAreaUnit.InverseUsSurveySquareFoot).ToString());
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

            Assert.Equal("1 cm⁻²", new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareCentimeter).ToString(swedishCulture));
            Assert.Equal("1 dm⁻²", new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareDecimeter).ToString(swedishCulture));
            Assert.Equal("1 ft⁻²", new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareFoot).ToString(swedishCulture));
            Assert.Equal("1 in⁻²", new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareInch).ToString(swedishCulture));
            Assert.Equal("1 km⁻²", new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareKilometer).ToString(swedishCulture));
            Assert.Equal("1 m⁻²", new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareMeter).ToString(swedishCulture));
            Assert.Equal("1 µm⁻²", new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareMicrometer).ToString(swedishCulture));
            Assert.Equal("1 mi⁻²", new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareMile).ToString(swedishCulture));
            Assert.Equal("1 mm⁻²", new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareMillimeter).ToString(swedishCulture));
            Assert.Equal("1 yd⁻²", new ReciprocalArea(1, ReciprocalAreaUnit.InverseSquareYard).ToString(swedishCulture));
            Assert.Equal("1 ft⁻² (US)", new ReciprocalArea(1, ReciprocalAreaUnit.InverseUsSurveySquareFoot).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentCulture;
            try
            {
                CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 m⁻²", new ReciprocalArea(0.123456, ReciprocalAreaUnit.InverseSquareMeter).ToString("s1"));
                Assert.Equal("0.12 m⁻²", new ReciprocalArea(0.123456, ReciprocalAreaUnit.InverseSquareMeter).ToString("s2"));
                Assert.Equal("0.123 m⁻²", new ReciprocalArea(0.123456, ReciprocalAreaUnit.InverseSquareMeter).ToString("s3"));
                Assert.Equal("0.1235 m⁻²", new ReciprocalArea(0.123456, ReciprocalAreaUnit.InverseSquareMeter).ToString("s4"));
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
            Assert.Equal("0.1 m⁻²", new ReciprocalArea(0.123456, ReciprocalAreaUnit.InverseSquareMeter).ToString("s1", culture));
            Assert.Equal("0.12 m⁻²", new ReciprocalArea(0.123456, ReciprocalAreaUnit.InverseSquareMeter).ToString("s2", culture));
            Assert.Equal("0.123 m⁻²", new ReciprocalArea(0.123456, ReciprocalAreaUnit.InverseSquareMeter).ToString("s3", culture));
            Assert.Equal("0.1235 m⁻²", new ReciprocalArea(0.123456, ReciprocalAreaUnit.InverseSquareMeter).ToString("s4", culture));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("en-US")]
        public void ToString_NullFormat_DefaultsToGeneralFormat(string cultureName)
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
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
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Equal(quantity.ToString(format, CultureInfo.CurrentCulture), quantity.ToString(format, null));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ReciprocalArea)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ReciprocalAreaUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Equal(ReciprocalArea.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Equal(ReciprocalArea.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(1.0);
            Assert.Equal(new {ReciprocalArea.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ReciprocalArea.FromInverseSquareMeters(value);
            Assert.Equal(ReciprocalArea.FromInverseSquareMeters(-value), -quantity);
        }
    }
}
