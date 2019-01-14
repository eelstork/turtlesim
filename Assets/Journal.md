# Monday Jan 14 - 12:00 PM

The only track in the game was too hard. Made another;
now I need a track selector.

(4:15) Unsurprisingly didn't get a chance to update this until
the Tortle jam end. Tagging the jam version.

Looks like the original game was made in 10~12 hours. At this
point biggest 'regrets' in order:

- Featured only one track, where 5 lines of code would give two.
- Only supported the gamepad
- Aspect ratio looks odd in my builds
- No web version

# Sunday Jan 13 - 2:43 PM

My biggest Q with this project is what type of joint should be used, if any. I
suppose a character joint or configurable joint will be it in the end. Maybe.
But for a quick prototype considering more simple solutions.

## 1. The model

In my first attempt I tried using Unity primitives (boxes) to create the model.
Bad idea because non uniform rescaling is needed to shape the boxes and this
messes hierarchies and possibly physics, so no.

I swapped this for a blender model. For now experimenting with a basic
hierarchy of objects.

An instant annoyance with using a Blender model is that it screws the
referential. All axis are pointing some other way than intuitive. Never mind.

## 2. Physics experimentation

### Fixed Joint - NO

The first joint I tried is a fixed joint. But fixed joints are just that:
fixed. This means that the paw can't rotate relative to the body.

### Character Joint

Moving to a character joint. Had to adjust the anchor a little and here goes.

The character joint has 3 degrees of freedom:
- Twist
- Swing 1
- Swing 2

These are dependent on the 'Axis' and 'Swing axis'; I find it rather confusing
but I could experiment by setting the shell to kinematic, and raising, it,
which lets a paw dangle off the shell.

Then I set limits for twist, swing 1, swing 2 to all zero and this actually
forces the paw to stick out and not rotate at all. Now I can relax limits to
see what axis does what, and I found that (for me) Swing 1 lets the paw rotate
around... well. Never mind. I'd need a diagram to show you that.

On top of that, joints have angular limits. So if these are angular limits,
what are the so called swing and twist limits? This isn't fun.

Frankly, I was thinking of abusing the joint limits to animate the rotation of
the paws. It's a bad idea and it's also going to be unpractical since just
figuring what the joints are doing has a learning curve.

But the character joint still has it going for it that, in the default
configuration it lets the paw rotate however it pleases around the shoulder
without stretching away from the shell.

### Applying a force

Now I want to apply a force to the paw since my goal is to give some traction
to the turtle. I have a choice of applying torques or just pushing.
A torque is directly trying to rotate the paw; intuitive? But rotations are a
little hell.
Locomotion using limbs is pushing on the ground, then moving a limb, then
pushing again. So, if we push on the 'end' of the paw we might be able to do
something like that.
Force, or torque? Let's try both. Of course to get started I just used simple
scripts where I can vary force intensity and direction in the editor. One
thing Unity is really helpful with.

#### Just one force

First I applied a force at the end of the paw. With that I could lift the paw
but not getting any traction. Not even after adding a rigid body to the ground.
Another thing is that this can't make the shell and paw rotate relative to each
other.

#### A torque

With a torque, we're generating a rotation around the axis. So unlike with the
force I apply that torque directly at the shoulder. This totally does a thing.

### Flapping a limb

The next thing I did just want was flapping a limb up and down. Luckily,
tweaking the torque axis just a little achieved forward traction.

>> https://youtu.be/nzeA4bQU-NQ

Going to clean the turtle tank now (5:14pm)

### Turtle complete

(6:30) My next step was moving all limbs, and adding a tail. Copying all the
components (body, collider, driver) was a little tedious. Another thing is,
as expected the torque direction is not the same for left and right limbs.

- Left:  `0, -1, -1`
- Right: `0,  1,  1`

With that, working turtle.

>> https://youtu.be/yaIalU-54Gw

## 3. Controls

So far the turtle is moving on its own. Might be useful but today we are
*controlling* the turtle.

Mapped controls to each leg. But now, each leg on its own does not have enough
traction to move the turtle. Can't tell whether that's real or not
(turtles are strong!) but it's no fun.

## 4. More Physics?

Of course we can increase the strength. But I feel that another problem here
is during locomotion, when a leg is at 'rest' it still generates a torque
that's used to keep the turtle off the ground.

Not hot handling these forces separately so how about we cancel gravity a
little by lifting the shell?

Another issue is mass. My turtle feels like 2 pounds; the paws aren't really heavy. In the initial setup all bodies had m = 1. So it would make sense if
the body was m = 0.5, and each paw ~ 0.1.

Results with all that inconclusive, or counter-productive.

Don't know what I'll do about this. For now the turtle is a bit slow for fun
so I cheated it and increased time scale.

## 5. The game

A want a game that's playable, and winnable; so I created a race track.

Also, trying this: https://ax23w4.itch.io/pixelate
