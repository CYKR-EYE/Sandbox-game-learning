using System.Linq.Expressions;
using Sandbox;

/// <summary>
/// All available teams
/// </summary>
public enum TeamType
{
	[Icon("🔵")]
	[Description( "Team blue is the best" )]
	Blue,
	[Icon( "🔴" )]
	[Description( "Red for ever !" )]
	Red,
}
public sealed class EvilCubeComponent : Component
{
	// Properties


	/// <summary>
	/// Name of the entity
	/// </summary>
	[Property]
	public string Name { get; set; }

	/// <summary>
	/// Team of the entity
	/// </summary>
	[Property]
	public TeamType Team { get; set; }

	/// <summary>
	/// Health of the entity
	/// </summary>
	[Property]
	[Range( 0, 100, 10 )]
	public float MaxHealth { get; set; } = 100f;


	private float _health;

	public float Health
	{
		get
		{
			return _health;
		}

		set
		{
			_health = value;
		}
	}

	[Property]
	public ModelRenderer ModelRenderer { get; set; }


	// Methods
	protected override void OnUpdate()
	{

	}

	protected override void OnStart()
	{
		_health = MaxHealth;
	}

	protected override void OnFixedUpdate()
	{
		
	}

	protected override void OnDestroy()
	{
		
	}

	private void UpdateHealth(float newHealth)
	{
		var difference = newHealth - Health;
		_health = float.Clamp(newHealth, 0f, MaxHealth );
	}
}
