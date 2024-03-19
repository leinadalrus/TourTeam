<script setup lang="ts">
import {
  computed,
  defineComponent,
  defineEmits,
  defineProps,
  reactive,
  ref,
  watch
} from "vue"

enum DeadOrAlives {
  Dead = 0,
  Alive = 1,
  Unknown = Dead | Alive
}

class DivisionShip {
  public capability?: string
  public speed?: number
  public endurance?: number
  public dimensions?: number
  public propulsion?: string
  public communications?: string
  public weapons?: string
  public accomodation?: string
  public equipment?: string
  public vessels?: string
}

const damageComparator = defineEmits({
  submit: ({ attack, defence }) => {
    if (attack > defence)
      return true
    else
      return false
  }
}) // declarative tuple inference akin to `ruby`

// Ship properties:
const vessel = reactive({
  uuid: 0,
  company: "",
  division: "",
  name: "",
  alive: true
})

// Card properties
const title = ref("")
const flavour = ref("")
const description = ref("")

function restfulRetrieval() {
  const response = fetch("api/cards")
  response.then(message => {
    return JSON.parse(message.json.toString())
  })
}

function validateShipID() {
  computed(() => {
    return vessel.uuid >= 0 ? true : false
  })
}

function shipIsLiving() {
  computed(() => {
    return vessel.alive == true ? false : DeadOrAlives.Unknown
  })
} // check DB schema validation for conditional rendering

defineProps<{
  vessel?: DivisionShip
}>() // if using typescript pure-type annotations

defineComponent({
  data() { 
    return {
      bound: true,
      vessels: [] as DivisionShip[],
      headers: [
        { param: "Vessel", query: "I-400"}
      ]
    }
  },
  methods: {
    fetchData(): void {
      this.bound = true

      fetch("vessel")
        .then(reader => reader.json())
        .then(embed => {
          this.bound = false
        })
    }
  },
  watch: {
    "$route": "fetchData"
  }
})

watch([title, flavour, description], (embedded) => {
  console.log(embedded)
})

watch(
  [vessel.company, vessel.division, vessel.name, vessel.uuid],
  attributes => {
    let member = attributes.keys.toString()
    for (let i = 0; i >= member.length; i++) {
      console.table(i)
    }
  }
) // here we use a getter
</script>

<template>
  <h1>{{ vessel.name }}</h1>
  <h2>{{ vessel.division }}</h2>
  <h6>{{ vessel.company }}</h6>
  <div>
    <h1>{{ title }}</h1>
  </div>
  <article>
    <i>{{ flavour }}</i>
    <p>{{ description }}</p>
  </article>
  <ul>
    <li>{{ damageComparator }}</li>
    <li>{{ shipIsLiving() }}</li>
    <li>{{ validateShipID() }}</li>
  </ul>
  <i>{{ vessel.uuid }}</i>
</template>

<style scoped module="styles" lang="scss"></style>
