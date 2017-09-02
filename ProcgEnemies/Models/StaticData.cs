using ProcgEnemies.Controllers;

namespace ProcgEnemies.Models
{
    public static class StaticData
    {
        public static EnemyAttribute[] MOVEMENT_ATTRS = new EnemyAttribute[]
        {
            new EnemyAttribute { Name = "Stationary", Description = "The enemy does no move at all.", Examples = "" },
            new EnemyAttribute { Name = "Walker", Description = "The enemy walks or runs along the ground.", Examples = "Super Mario's Goombas" },
            new EnemyAttribute { Name = "Riser", Description = "The enemy can increase its height (often, can rise from nothing).", Examples = "Super Mario's Piranha Plants and Castlevania's Mud Man" },
            new EnemyAttribute { Name = "Ducker", Description = "The enemy can reduce its height (including, melting into the floor).", Examples = "Super Mario's Piranha Plants" },
            new EnemyAttribute { Name = "Faller", Description = "The enemy falls from the ceiling onto the ground.", Examples = "Usually these enemies are drops of something, like acid. Some games have slimes that do this." },
            new EnemyAttribute { Name = "Jumper", Description = "The enemy can bounce or jump. (some jump forward, some jump straight up and down).", Examples = "Donkey Kong's Springs, Super Mario 2's Tweeter, Super Mario 2's Ninji" },
            new EnemyAttribute { Name = "Floater", Description = "The enemy can float, fly, or levitate.", Examples = "Castlevania's Bats" },
            new EnemyAttribute { Name = "Sticky", Description = "The enemy sticks to walls and ceilings.", Examples = "Super Mario 2's Spark" },
            new EnemyAttribute { Name = "Waver", Description = "The enemy floats in a sine wave pattern.", Examples = "Castlevania's Medusa Head" },
            new EnemyAttribute { Name = "Rotator", Description = "The enemy rotates around a fixed point. Sometimes, the fixed point moves, and can move according to any movement EnemyAttribute in this list. Also, the rotation direction may change.", Examples = "Super Mario 3's Rotodisc" },
            new EnemyAttribute { Name = "Swinger", Description = "The enemy swings from a fixed point.", Examples = "Castlevania's swinging blades" },
            new EnemyAttribute { Name = "Pacer", Description = "The enemy changes direction in response to a trigger (like reaching the edge of a platform).", Examples = "Super Mario's Red Koopas" },
            new EnemyAttribute { Name = "Follower", Description = "The enemy follows the player (Often used in top-down games).", Examples = "Zelda 3's Hard Hat Beetles" },
            new EnemyAttribute { Name = "Roamer", Description = "The enemy changes direction completely randomly.", Examples = "Legend of Zelda's Octoroks" },
            new EnemyAttribute { Name = "Liner", Description = "The enemy moves directly to a spot on the screen.", Examples = "" },
            new EnemyAttribute { Name = "Teleporter", Description = "The enemy can teleport from one location to another.", Examples = "Zelda's Wizrobes" },
            new EnemyAttribute { Name = "Dasher", Description = "The enemy dashes in a direction, faster than its normal movement speed.", Examples = "Zelda's Rope Snakes" },
            new EnemyAttribute { Name = "Ponger", Description = "The enemy ignores gravity and physics, and bounces off walls in straight lines.", Examples = "Zelda 2's Bubbles" },
            new EnemyAttribute { Name = "Geobound", Description = "The enemy is physically stuck to the geometry of the level, sometimes appears as level geometry.", Examples = "Megaman's Spikes, Super Mario's Piranha Plants, CastleVania's White Dragon" },
            new EnemyAttribute { Name = "Tethered", Description = "The enemy is tethered to the level's geometry by a chain or a rope.", Examples = "Super Mario's Chain Chomps" },
            new EnemyAttribute { Name = "Swooper", Description = "A floating enemy that swoops down, often returning to its original position, but not always.", Examples = "Castlevania's Bats, Super Mario's Swoopers, Super Mario 3's Angry Sun" }
        };

        public static EnemyAttribute[] PASSIVE_ATTRS = new EnemyAttribute[]
        {
            new EnemyAttribute { Name = "GeoIgnore", Description = "The enemy ignores the properties of the level's geometry and can pass through solid objects.", Examples = "Super Mario 3's Rotodisc, many flying enemies will ignore geometry as well." },
            new EnemyAttribute { Name = "Shielder", Description = "Player attacks are nullified when hit from a specific direction or angle, or hit a specific spot on the enemy.", Examples = "Zelda 2's Dark Nuts" },
            new EnemyAttribute { Name = "Deflector", Description = "Player's ranged attacks are reflected when the enemy is hit by them.", Examples = "" },
            new EnemyAttribute { Name = "Secret spot", Description = "The enemy has a specific spot where damage can only be taken when that spot is hit. The opposite of a Shielder.", Examples = "Many bosses have this attribute." },
            new EnemyAttribute { Name = "Invulnerable", Description = "The enemy cannot be harmed or killed.", Examples = "Most are geometry based hazards (spikes, mashing blocks, fire spouts), but also includes enemies like Super Mario 3's Boo Brothers." },
            new EnemyAttribute { Name = "Revivor", Description = "The enemy is revived after dying.", Examples = "Castlevania's Skeletons, Super Mario's Dry Bones." },
            new EnemyAttribute { Name = "Regenerator", Description = "The enemy's health is regenerated over time", Examples = "" },
            new EnemyAttribute { Name = "Secret Weakness", Description = "The enemy is vulnerable to specific types of attacks (fire, magic, arrows, etc).", Examples = "Zelda's Dodogno (weakness to bombs)." },
            new EnemyAttribute { Name = "Hard to Hit", Description = "These enemies are specifically hard to hit with by the player's normal attack ranges. They are aften very fast, or very tiny.", Examples = "Zelda 2's Myu" },
            new EnemyAttribute { Name = "Segmented", Description = "These enemies are made up of smaller individual objects. Each individual segment can often be destroyed independently, and are often in snake-form.", Examples = "" },
            new EnemyAttribute { Name = "Bumper", Description = "These enemies act like pinball bumpers, pushing the player (or other objects) away quickly.", Examples = "Zelda 3's Hard Hat Beetles" },
            new EnemyAttribute { Name = "GeoMimic", Description = "These enemies have properties of level geometry. Most commonly, the player can stand on them.", Examples = "Most enemies in Mario 2, Megaman X's Sigma, Castlevania's Catoblepas" },
            new EnemyAttribute { Name = "Alarm", Description = "An enemy or object that causes another enemy or object to react.", Examples = "" }
        };

        public static EnemyAttribute[] ABILITY_ATTRS = new EnemyAttribute[]
        {
            new EnemyAttribute { Name = "Grower", Description = "The enemy can grow in size.", Examples = "" },
            new EnemyAttribute { Name = "Shrinker", Description = "The enemy can shrink in size.", Examples = "" },
            new EnemyAttribute { Name = "Forcer", Description = "The enemy can apply direct movement force to the player.", Examples = "Treadmills found in most games apply, as well as enemies who blow air at the player, causing them to move backwards." },
            new EnemyAttribute { Name = "Carrier", Description = "The enemy can carry another enemy, an object, or the player. Enemies that pick up the player, that 'eat' the player and spit it out again, or otherwise grab and restrict the movement of the player", Examples = "Zelda's WallMasters" },
            new EnemyAttribute { Name = "Thrower", Description = "The enemy can throw whatever it is holding (an object, the player, or another enemy). This is often combined with Carriers, but not always.", Examples = "Castlevania's Barrel throwing Skeletons, Super Mario 3's Buster Beetle" },
            new EnemyAttribute { Name = "Emitter", Description = "The enemy 'emits' another enemy or projectile. This type is very similar to the Thrower, and the differences are mostly semantic. The main difference being that throwers throw an object they've picked up or spawn with, while Emitters have an infinite supply of the things they can throw out.", Examples = "Super Mario 3's Bullet Bill Cannons, Super Mario's Lakitus, anything that has a gun, Gauntlet's enemy spawners." },
            new EnemyAttribute { Name = "Splitter", Description = "The enemy can split into multiple other enemies while destroying itself.", Examples = "Rogue Legacy's Slimes, Legend of Zelda's Vire and Biri." },
            new EnemyAttribute { Name = "Cloner", Description = "The enemy can duplicate itself. Often, the duplicate is an exact clone, but sometimes, the duplicate is very slightly modified (such as having reduced health, or being faster). The enemy that does the cloning is not destroyed.", Examples = "Zelda's Ghini" },
            new EnemyAttribute { Name = "Morpher", Description = "The enemy morphs into another enemy type. Sometimes, this is temporary, and sometimes, the enemy will morph into multiple other types of enemies.", Examples = "" },
            new EnemyAttribute { Name = "Sapper", Description = "The enemy can cause the player's stats to be modified (slower speed, reduced or eliminated jump, inability to attack, etc). These effects can be either permanent or temporary.", Examples = "" },
            new EnemyAttribute { Name = "Latcher", Description = "Like a Sapper, the enemy can drain the player's stats and abilities, but does so by latching on to the player.", Examples = "Mario 3's Mini-Goombas, Zelda's Like-Likes." },
            new EnemyAttribute { Name = "Hider", Description = "The enemy can hide from the player. Typically, the enemy is hidden until the player comes within a set distance, or the inverse where the enemy hides once the player comes too close.", Examples = "Mario's Piranha Plants." },
            new EnemyAttribute { Name = "Switcher", Description = "The enemy can toggle between various attributes, such as being stationary and invincible and switching to being a pacer and vulnerable.", Examples = "Mario's Boo Brothers, Zelda's Peahats." },
            new EnemyAttribute { Name = "Exploder", Description = "The enemy can destroy itself and cause splash damage.", Examples = "Proximity Mines found in many games, Mario's Bo-Bombs" },
            new EnemyAttribute { Name = "Interactor", Description = "The enemy can interact with scripted objects, such as levers or buttons.", Examples = "" }
        };

        public static EnemyAttribute[] TRIGGER_ATTRS = new EnemyAttribute[]
        {
            new EnemyAttribute { Name = "On Hit", Description = "Is hit by player", Examples = "" },
            new EnemyAttribute { Name = "On Damage", Description = "Hits player", Examples = "" },
            new EnemyAttribute { Name = "Timer", Description = " After X seconds, change behavior", Examples = "this is most typical of bosses" },
            new EnemyAttribute { Name = "Sequence", Description = "Follows another action it previously performed", Examples = "After the enemy attacks, it dashes backwards" },
            new EnemyAttribute { Name = "Proximity", Description = " Distance to the player or an object", Examples = "" },
            new EnemyAttribute { Name = "Random", Description = " Enemies randomly choose their next behavior or set of attributes in their AI", Examples = "" },
            new EnemyAttribute { Name = "Line of Sight", Description = "The player has direct line of sight to the enemy", Examples = "" },
            new EnemyAttribute { Name = "No Line of Sight", Description = "The player does not have direct line of sight to the enemy.", Examples = "" }
        };
    }
}