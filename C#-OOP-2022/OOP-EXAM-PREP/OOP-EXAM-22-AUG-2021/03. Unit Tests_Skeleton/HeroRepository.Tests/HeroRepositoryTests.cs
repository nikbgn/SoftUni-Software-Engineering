using System;
using NUnit.Framework;

public class HeroRepositoryTests
{
    [Test]
    public void Test_Create_Should_Work()
    {

        HeroRepository heroRepo = new HeroRepository();
        Hero h1 = new Hero("n", 1);
        heroRepo.Create(h1);
        Assert.That(heroRepo.Heroes.Count, Is.EqualTo(1));

    }
    [Test]
    public void Test_Create_Should_Throw_Error()
    {
        HeroRepository heroRepo = new HeroRepository();
        Hero h1 = null;
        Hero h2 = new Hero("j", 1);
        Hero h3 = new Hero("j", 1);
        Assert.Throws<ArgumentNullException>(() =>
        {
            heroRepo.Create(h1);
        });


        heroRepo.Create(h2);

        Assert.Throws<InvalidOperationException>(() =>
        {
            heroRepo.Create(h3);
        });


    }

    [Test]
    public void Test_Remove_Should_Work()
    {

        HeroRepository heroRepo = new HeroRepository();
        Hero h1 = new Hero("n", 1);
        heroRepo.Create(h1);
        Assert.IsTrue(heroRepo.Remove("n"));
    }
    [Test]
    public void Test_Remove_Should_Throw_Error()
    {
        HeroRepository heroRepo = new HeroRepository();
        Hero h1 = new Hero("n", 1);
        heroRepo.Create(h1);
        Assert.Throws<ArgumentNullException>(() =>
        {
            heroRepo.Remove(null);
        });
        Assert.Throws<ArgumentNullException>(() =>
        {
            heroRepo.Remove("");
        });
        Assert.Throws<ArgumentNullException>(() =>
        {
            heroRepo.Remove(" ");
        });
    }

    [Test]
    public void Test_GetHeroWithHighestLevel_Should_Work()
    {

        HeroRepository heroRepo = new HeroRepository();
        Hero h1 = new Hero("n", 1);
        Hero h2 = new Hero("ff", 90);
        heroRepo.Create(h1);
        heroRepo.Create(h2);
        Assert.That(heroRepo.GetHeroWithHighestLevel().Level, Is.EqualTo(90));
    }

    [Test]
    public void Test_GetHero_Should_Work()
    {
        HeroRepository heroRepo = new HeroRepository();
        Hero h1 = new Hero("n", 1);
        Hero h2 = new Hero("ff", 90);
        heroRepo.Create(h1);
        Assert.That(heroRepo.GetHero("n").Level, Is.EqualTo(1));

    }

    [Test]
    public void Test_Heroes_Should_Work()
    {
        HeroRepository heroRepo = new HeroRepository();
        Hero h1 = new Hero("n", 1);
        heroRepo.Create(h1);
        Assert.That(heroRepo.Heroes.Count, Is.EqualTo(1));

    }


}