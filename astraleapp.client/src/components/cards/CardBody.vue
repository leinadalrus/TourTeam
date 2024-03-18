<script setup lang="ts">
import {
  computed,
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

const DivisionShip = reactive({
}) // Fetch JSON data of Mercenary Pilots

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

defineProps<{
  lancer?: typeof DivisionShip
}>() // if using typescript pure-type annotations
</script>

<template>
  <h1>{{ vessel.name }}</h1>
  <h2>{{ vessel.division }}</h2>
  <h6>{{ vessel.company }}</h6>
  <div :class="styles.CardBanner">
    <h1>{{ title }}</h1>
  </div>
  <article :class="styles.CardContainer">
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

<style scoped module="styles" lang="scss">
.CardBanner {
  text-orientation: sideways;
  writing-mode: vertical-rl;
  word-break: break-word;
  max-height: 32vh;
}

.CardContainer {
  display: flex;
  overflow: scroll;

  flex: 1;
  background-color: #0f1014;
  align-items: center;
  justify-content: center;

  scrollbar-width: none;
  -ms-overflow-style: none;
}

.CardLayer {
  clip-path: polygon(
    0 0%,
    100% 0,
    100% calc(100% - 0rem),
    calc(100% - 0rem) 100%,
    0 100%,
    0% calc(100% - 0rem)
  );

  max-width: 15vw;
  max-height: 32vh;

  padding: 0.25rem 1rem;
  margin: auto;

  opacity: 99%;

  backdrop-filter: blur(5.75256333rem);
  background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='4' height='4' viewBox='0 0 4 4'%3E%3Cpath fill='%234065b0' fill-opacity='0.4' d='M1 3h1v1H1V3zm2-2h1v1H3V1z'%3E%3C/path%3E%3C/svg%3E");
  background-color: #000614;

  border: none;
  box-shadow: 1rem 1rem 4.912423rem rgba(3, 2, 3, 0.1),
    -1rem 1rem 4.912423rem rgba(9, 2, 6, 0.1);
  cursor: pointer;
  color: #f7f9fe;

  right: 17.5rem;
}
</style>

