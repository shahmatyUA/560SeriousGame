using Core.Utilities;
using UnityEngine;

namespace TowerDefense.Level
{
	/// <summary>
	/// A wave implementation that triggers the waveCompleted event after an elapsed amount of time
	/// </summary>
	public class TimedWave : Wave
	{

		public int totalInfections = 0;
		public AllTowerData allTowerData;
		private int infectionIndex = 0;
		private float[] infectionTimes;

        /// <summary>
        /// The time until the next wave is started
        /// </summary>
        [Tooltip("The time until the next wave is started")]
		public float timeToNextWave = 10f;

		/// <summary>
		/// The timer used to start the next wave
		/// </summary>
		protected Timer m_WaveTimer;

		public override float progress
		{
			get { return m_WaveTimer == null ? 0 : m_WaveTimer.normalizedProgress; }
		}

		/// <summary>
		/// Initializes the Wave
		/// </summary>
		public override void Init()
		{
			base.Init();

			if (spawnInstructions.Count > 0)
			{
				m_WaveTimer = new Timer(timeToNextWave, SafelyBroadcastWaveCompletedEvent);
				StartTimer(m_WaveTimer);
			}

			// Set up the infection times
			SetUpInfectionTimes();
			//Debug.Log("Infection times: " + string.Join(", ", infectionTimes));
		}

		/// <summary>
		/// Handles spawning the current agent and sets up the next agent for spawning
		/// </summary>
		protected override void SpawnCurrent()
		{
			ActivateInfection();
            Spawn();
			if (!TrySetupNextSpawn())
			{
				StopTimer(m_SpawnTimer);
			}
		}

		private void SetUpInfectionTimes()
		{
            // set times for when the tower disblaing should happen
            infectionTimes = new float[totalInfections];
            for (int i = 0; i < totalInfections; i++)
            {
                infectionTimes[i] = (i + 1) / (totalInfections + 1f); 
            }

			// apply some randomness but also make sure it stays within normalized time {0,1}
            float jitterAmount = 1f / (totalInfections * 3f);

            for (int i = 0; i < totalInfections; i++)
            {
                infectionTimes[i] += Random.Range(-jitterAmount, jitterAmount);
                infectionTimes[i] = Mathf.Clamp01(infectionTimes[i]); 
            }
        }

		private void ActivateInfection()
		{
			if (infectionIndex >= totalInfections)
			{
                return;
            }
			//Debug.Log("Infection index" + infectionIndex + " infection time" + infectionTimes[infectionIndex] + " " + m_WaveTimer.normalizedProgress);
			if (infectionTimes[infectionIndex] <= m_WaveTimer.normalizedProgress)
			{
				allTowerData.InfectTower();
				infectionIndex++;
			}
		}
	}
}