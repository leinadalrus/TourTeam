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

const Lancer = reactive({
  lancerID: 0,
  company: "",
  faction: "",
  lastname: "",
  firstname: "",
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

function validateLancerID() {
  computed(() => {
    return Lancer.lancerID >= 0 ? true : false
  })
}

function lancerIsLiving() {
  computed(() => {
    return Lancer.alive == true ? false : DeadOrAlives.Unknown
  })
} // check DB schema validation for conditional rendering

watch(
  () => Lancer.lancerID,
  lancerID => {
    console.table(lancerID)
  }
) // here we use a getter

defineProps<{
  lancer?: typeof Lancer
}>() // if using typescript pure-type annotations
</script>

<template>
  <h1>{{ Lancer.lastname }}</h1>
  <h2>{{ Lancer.firstname }}</h2>
  <img src="" alt="">
  <span>
    {{ Lancer.company }}
    {{ Lancer.faction }}
  </span>
  <address>
    {{ damageComparator }}
    {{ lancerIsLiving }}
    {{ validateLancerID }}
  </address>
</template>

<style scoped module="styles" lang="scss"></style>

