<script setup lang="ts">
import {
  computed,
  defineEmits,
  defineProps,
  reactive,
  watch
} from "vue"

enum DeadOrAlives {
  Dead = 0,
  Alive = 1,
  Unknown = Dead | Alive
}

const DivisionShip = reactive({
  uuid: 0,
  company: "",
  division: "",
  name: "",
  alive: true
}) // Fetch JSON data of Mercenary Pilots

const damageComparator = defineEmits({
  submit: ({ attack, defence }) => {
    if (attack > defence)
      return true
    else
      return false
  }
}) // declarative tuple inference akin to `ruby`

function restfulRetrieval() {
  const response = fetch("localhost:8080/api/cards")
  response.then(message => {
    return JSON.parse(message.json.toString())
  })
}

function validateShipID() {
  computed(() => {
    return DivisionShip.uuid >= 0 ? true : false
  })
}

function shipIsLiving() {
  computed(() => {
    return DivisionShip.alive == true ? false : DeadOrAlives.Unknown
  })
} // check DB schema validation for conditional rendering

watch(
  () => DivisionShip.uuid,
  shipID => {
    console.table(shipID)
  }
) // here we use a getter

defineProps<{
  lancer?: typeof DivisionShip
}>() // if using typescript pure-type annotations
</script>

<template>
  <h1>{{ DivisionShip.name }}</h1>

  <h2>{{ DivisionShip.division }}</h2>
  <img src="" alt="">
  <span>
    {{ DivisionShip.company }}
  </span>
  <ul>
    <li>{{ damageComparator }}</li>
    <li>{{ ShipIsLiving }}</li>
    <li>{{ validateShipID }}</li>
  </ul>
</template>

<style scoped module="styles" lang="scss"></style>

