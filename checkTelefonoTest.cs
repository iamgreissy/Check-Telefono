using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Xunit;


public class TelefonoTest
{
    [Fact]
    public void numerCasa()
    {
        Assert.Equal("3349989823", Telefono.Check(new string[]{"05418888", "3349989823"}));
    }

    [Fact]
    public void numerCellConPrefissoZeroZero()
    {
        Assert.Equal("00393349989823", Telefono.Check(new string[]{"05418888", "00393349989823", "+39123456774"}));
    }

    [Fact]
    public void numerCellConPrefissoZeroZero1()
    {
        Assert.Equal("", Telefono.Check(new string[]{"05418888", "+00393349989823", "0019123456774"}));
    }

    [Fact]
    public void numerCellConPrefissoSbagliato()
    {
        Assert.Equal("", Telefono.Check(new string[]{"05418888", "+00393349989823"}));
    }

    [Fact]
    public void numerCellConPrefissoPiu()
    {
        Assert.Equal("+393349989823", Telefono.Check(new string[]{"05418888", "+393349989823"}));
    }
}